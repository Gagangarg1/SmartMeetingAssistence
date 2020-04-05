using Microsoft.CognitiveServices.Speech;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextRank;
using System.Linq;
using System.Collections.Generic;

namespace SmartMeetingAssistant
{
    public partial class SmartMeetingAssistant : Form
    {
        static StringBuilder meetingLog = null;
        static StringBuilder meetingText = null;
        static string meetingMOM = null;
        bool isRecording = false;
        CancellationTokenSource cts;
        static int minLimit;
        static string region = null;
        int meetingID = 0;
        public SmartMeetingAssistant()
        {
            InitializeComponent();
            meetingStatusLabel.Hide();
            meetingTitleTextBox.Text = "Enter a title for your meeting and Click above to start..";
            startNewMeetingButton.Hide();
            viewMOMButton.Hide();
            HideConfiguration();

            DataAccess access = new DataAccess();
            List<KeyValuePair<string, string>> config = access.GetConfiguration();
            if (config == null)
            {
                MessageBox.Show("Error fetching config data. Please check logs to troubleshoot");
                return;
            }
            minLimit = Convert.ToInt32(config.FirstOrDefault(x => x.Key == "MinCharToComputeMOM").Value.ToString());
            region = config.FirstOrDefault(x => x.Key == "SpeechRegion").Value.ToString();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void startMeetingButton_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                MessageBox.Show("A meeting is already going on , Please stop it to start new one.");
                return;
            }
            button1_Click_1(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // View Meeting Logs Button Click
            if (isRecording)
            {
                MessageBox.Show("Logs can not be viewed during a meeting. Please stop the current meeting to continue..");
                return;
            }
            DataAccess dataAccess = new DataAccess();
            var meetingLogsData = dataAccess.GetAllMeetingLogsData();
            if (meetingLogsData == null)
            {
                MessageBox.Show("Could not fetch Meeting Logs due to an Error !");
                return;
            }
            GridViewDisplay.Show();
            GridViewDisplay.BringToFront();
            GridViewDisplay.DataSource = meetingLogsData;
            GridViewDisplay.Columns[1].Width = 615;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Analyse MOM button Click
            if (isRecording)
            {
                MessageBox.Show("Meeting MOM can not be viewed while a meeting is still going on, Please stop the current meeting to continue..");
                return;
            }
            DataAccess dataAccess = new DataAccess();
            var meetingData = dataAccess.GetAllMeetingData();
            if (meetingData == null)
            {
                MessageBox.Show("Could not fetch Meeting summery due to an Error !");
                return;
            }
            GridViewDisplay.Show();
            GridViewDisplay.BringToFront();
            GridViewDisplay.DataSource = meetingData;
            GridViewDisplay.Columns[0].Visible = false;
            GridViewDisplay.Columns[1].Width = 200;
            GridViewDisplay.Columns[2].Width = 120;
            GridViewDisplay.Columns[3].Width = 120;
            GridViewDisplay.Columns[4].Width = 138;
            GridViewDisplay.Columns[5].Width = 138;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Configuration Button Click
            if (isRecording)
            {
                MessageBox.Show("Can not open configuration due to an ongoing meeting, Please stop it to continue..");
                return;
            }
            pictureBox1.Hide();
            meetingTitleTextBox.Hide();
            GridViewDisplay.Hide();
            GridViewDisplay.SendToBack();
            configLabel1.Show();
            ConfigLabel2.Show();
            SpeechRegionTextBox.Show();
            MinCharToComputeMOMTextBox.Show();
            updateConfigButton.Show();
            MinCharToComputeMOMTextBox.Text = minLimit.ToString();
            SpeechRegionTextBox.Text = region;


        }

        private void HideConfiguration()
        {
            configLabel1.Hide();
            ConfigLabel2.Hide();
            SpeechRegionTextBox.Hide();
            MinCharToComputeMOMTextBox.Hide();
            updateConfigButton.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Speech to Text button Click 
            if (isRecording)
            {
                MessageBox.Show("Can not open the Speech to Text Module due to an ongoing meeting. Please stop it to continue..");
                return;
            }
            GridViewDisplay.Hide();
            HideConfiguration();
            pictureBox1.Show();
            meetingTitleTextBox.Show();
            MessageBox.Show("Use the start meeting feature to convert Speech to Text. This will save converted text along with its summary.");
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            HideConfiguration();
            if (string.IsNullOrWhiteSpace(meetingTitleTextBox.Text) || meetingTitleTextBox.Text == "Enter a title for your meeting and Click above to start..")
            {
                MessageBox.Show("Please enter a valid title for the Meeting");
                return;
            }
            var startDate = DateTime.Now;
            var meetingTitle = meetingTitleTextBox.Text;
            if (meetingText == null || meetingLog == null)
            {
                meetingText = new StringBuilder();
                meetingLog = new StringBuilder();
                meetingLog.Append("Meeting Recording Started for Meeting Title :" + meetingTitleTextBox.Text + " at " + startDate + "\n");
            }

            meetingTitleTextBox.Hide();
            isRecording = true;
            meetingStatusLabel.Text = "Meeting is being recorded. Click again to stop.";
            meetingStatusLabel.Show();
            if (cts == null)
            {
                cts = new CancellationTokenSource();
                try
                {
                    await RecognizeSpeechAsync(cts.Token);
                }
                catch (OperationCanceledException)
                {
                }
                finally
                {
                    cts = null;
                }
            }
            else
            {
                cts.Cancel();
                cts = null;
                DataAccess saveResults = new DataAccess();
                var extractKeyPhrases = new ExtractKeyPhrases();
                meetingMOM = meetingText.Length > minLimit ? extractKeyPhrases.Extract(meetingText.ToString()).Item1 : meetingText.ToString();
                meetingID = saveResults.SaveMeetingData(meetingTitle, startDate, meetingText.ToString(), meetingMOM, DateTime.Now);
                Logger logger = new Logger();
                logger.SaveMeetingLogs(meetingID, meetingLog.ToString());
                meetingStatusLabel.Text = "        Your meeting has been Recorded.        ";
                startNewMeetingButton.Show();
                viewMOMButton.Show();
                isRecording = false;
            }
        }

        public static async Task RecognizeSpeechAsync(CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }

            var config = SpeechConfig.FromSubscription("400c8d1d7bf74b968567b88ff765500e", region);
            using (var recognizer = new SpeechRecognizer(config))
            {
                var result = await recognizer.RecognizeOnceAsync();

                if (result.Reason == ResultReason.RecognizedSpeech)
                {
                    meetingText.Append(result.Text);
                    await RecognizeSpeechAsync(token);
                }
                else if (result.Reason == ResultReason.NoMatch)
                {
                    meetingLog.Append($"NOMATCH: Speech could not be recognized.");
                    await RecognizeSpeechAsync(token);
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    await RecognizeSpeechAsync(token);
                    var cancellation = CancellationDetails.FromResult(result);
                    meetingLog.Append($"CANCELED: Reason={cancellation.Reason}");

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        meetingLog.Append($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                        meetingLog.Append($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                        meetingLog.Append($"CANCELED: Did you update the subscription info?");
                    }
                }
            }
        }

        private void meetingStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void meetingTitleTextBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void meetingTitleTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            meetingTitleTextBox.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HideConfiguration();
            GridViewDisplay.SendToBack();
            GridViewDisplay.Hide();
            meetingTitleTextBox.Text = "Enter a title for your meeting and Click above to start..";
            meetingTitleTextBox.Show();
            meetingStatusLabel.Hide();
            meetingLog = null;
            meetingText = null;
            cts = null;
            startNewMeetingButton.Hide();
            viewMOMButton.Hide();
            currentMeetingMOMTextBox.Text = "";
            currentMeetingMOMTextBox.Hide();
            pictureBox1.Show();
        }

        private void viewMOMButton_Click(object sender, EventArgs e)
        {
            HideConfiguration();
            GridViewDisplay.SendToBack();
            GridViewDisplay.Hide();
            currentMeetingMOMTextBox.Show();
            currentMeetingMOMTextBox.BringToFront();
            pictureBox1.Hide();
            meetingTitleTextBox.Hide();
            meetingStatusLabel.Hide();
            meetingLog = null;
            meetingText = null;
            cts = null;
            startNewMeetingButton.Hide();
            viewMOMButton.Hide();
            if (string.IsNullOrEmpty(meetingMOM))
            {
                currentMeetingMOMTextBox.Text = "Could not Generate MOM, Something went wrong. Please check logs for more details!";
            }
            else
            {
                currentMeetingMOMTextBox.Text = meetingMOM;
            }
            startNewMeetingButton.Show();
            startNewMeetingButton.BringToFront();
        }

        private void troubleshootingButton_Click(object sender, EventArgs e)
        {
            // Troubleshooting button Click
            if (isRecording)
            {
                MessageBox.Show("Logs can not be viewed during a meeting. Please stop the current meeting to continue..");
                return;
            }

            HideConfiguration();
            DataAccess dataAccess = new DataAccess();
            var meetingLogsData = dataAccess.GetAllExceptionLogData();
            if (meetingLogsData == null)
            {
                MessageBox.Show("Could not fetch Exception Logs due to an Error !");
                return;
            }
            GridViewDisplay.Show();
            GridViewDisplay.BringToFront();
            GridViewDisplay.DataSource = meetingLogsData;
            GridViewDisplay.Columns[0].Visible = false;
            GridViewDisplay.Columns[1].Width = 150;
            GridViewDisplay.Columns[2].Width = 560;
        }

        private void updateConfigButton_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(SpeechRegionTextBox.Text) || SpeechRegionTextBox.Text != "eastus")
            {
                MessageBox.Show("Please Enter a Valid value for Speech region!");
                return;
            }
            int validInt;
            if (string.IsNullOrWhiteSpace(MinCharToComputeMOMTextBox.Text) || !int.TryParse(MinCharToComputeMOMTextBox.Text, out validInt))
            {
                MessageBox.Show("Entered Value for Min character to compute MOM is not a valid number!");
                return;
            }


            DataAccess access = new DataAccess();
            if (access.UpdateConfiguration(MinCharToComputeMOMTextBox.Text, SpeechRegionTextBox.Text))
            {
                minLimit = Convert.ToInt32(MinCharToComputeMOMTextBox.Text);
                region = SpeechRegionTextBox.Text;
                MessageBox.Show("Configuration has been updated successfully!");
                return;
            }
            MessageBox.Show("Something went wrong while updating the configuration!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void configLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
