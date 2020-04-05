namespace SmartMeetingAssistant
{
    partial class SmartMeetingAssistant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartMeetingAssistant));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.troubleshootingButton = new System.Windows.Forms.Button();
            this.speechToTextButton = new System.Windows.Forms.Button();
            this.configurationButton = new System.Windows.Forms.Button();
            this.analyseMOMButton = new System.Windows.Forms.Button();
            this.viewLogsButton = new System.Windows.Forms.Button();
            this.startMeetingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.viewMOMButton = new System.Windows.Forms.Button();
            this.startNewMeetingButton = new System.Windows.Forms.Button();
            this.meetingTitleTextBox = new System.Windows.Forms.TextBox();
            this.meetingStatusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentMeetingMOMTextBox = new System.Windows.Forms.TextBox();
            this.GridViewDisplay = new System.Windows.Forms.DataGridView();
            this.meetingDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configLabel1 = new System.Windows.Forms.Label();
            this.ConfigLabel2 = new System.Windows.Forms.Label();
            this.SpeechRegionTextBox = new System.Windows.Forms.TextBox();
            this.MinCharToComputeMOMTextBox = new System.Windows.Forms.TextBox();
            this.updateConfigButton = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.troubleshootingButton);
            this.sidePanel.Controls.Add(this.speechToTextButton);
            this.sidePanel.Controls.Add(this.configurationButton);
            this.sidePanel.Controls.Add(this.analyseMOMButton);
            this.sidePanel.Controls.Add(this.viewLogsButton);
            this.sidePanel.Controls.Add(this.startMeetingButton);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 513);
            this.sidePanel.TabIndex = 0;
            // 
            // troubleshootingButton
            // 
            this.troubleshootingButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troubleshootingButton.Location = new System.Drawing.Point(0, 380);
            this.troubleshootingButton.Name = "troubleshootingButton";
            this.troubleshootingButton.Size = new System.Drawing.Size(200, 55);
            this.troubleshootingButton.TabIndex = 6;
            this.troubleshootingButton.Text = "Troubleshooting";
            this.troubleshootingButton.UseVisualStyleBackColor = true;
            this.troubleshootingButton.Click += new System.EventHandler(this.troubleshootingButton_Click);
            // 
            // speechToTextButton
            // 
            this.speechToTextButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechToTextButton.Location = new System.Drawing.Point(0, 318);
            this.speechToTextButton.Name = "speechToTextButton";
            this.speechToTextButton.Size = new System.Drawing.Size(200, 55);
            this.speechToTextButton.TabIndex = 5;
            this.speechToTextButton.Text = "Speech to Text";
            this.speechToTextButton.UseVisualStyleBackColor = true;
            this.speechToTextButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // configurationButton
            // 
            this.configurationButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationButton.Location = new System.Drawing.Point(0, 257);
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.Size = new System.Drawing.Size(200, 55);
            this.configurationButton.TabIndex = 4;
            this.configurationButton.Text = "Configuration";
            this.configurationButton.UseVisualStyleBackColor = true;
            this.configurationButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // analyseMOMButton
            // 
            this.analyseMOMButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyseMOMButton.Location = new System.Drawing.Point(0, 196);
            this.analyseMOMButton.Name = "analyseMOMButton";
            this.analyseMOMButton.Size = new System.Drawing.Size(200, 55);
            this.analyseMOMButton.TabIndex = 3;
            this.analyseMOMButton.Text = "Analyse MOM";
            this.analyseMOMButton.UseVisualStyleBackColor = true;
            this.analyseMOMButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewLogsButton
            // 
            this.viewLogsButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogsButton.Location = new System.Drawing.Point(0, 135);
            this.viewLogsButton.Name = "viewLogsButton";
            this.viewLogsButton.Size = new System.Drawing.Size(200, 55);
            this.viewLogsButton.TabIndex = 2;
            this.viewLogsButton.Text = "View Meeting Logs";
            this.viewLogsButton.UseVisualStyleBackColor = true;
            this.viewLogsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startMeetingButton
            // 
            this.startMeetingButton.Font = new System.Drawing.Font("Sitka Subheading", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMeetingButton.Location = new System.Drawing.Point(0, 74);
            this.startMeetingButton.Name = "startMeetingButton";
            this.startMeetingButton.Size = new System.Drawing.Size(200, 55);
            this.startMeetingButton.TabIndex = 1;
            this.startMeetingButton.Text = "Start Meeting";
            this.startMeetingButton.UseVisualStyleBackColor = true;
            this.startMeetingButton.Click += new System.EventHandler(this.startMeetingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 74);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.topPanel.Controls.Add(this.appNameLabel);
            this.topPanel.Controls.Add(this.minimizeLabel);
            this.topPanel.Controls.Add(this.closeLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(759, 74);
            this.topPanel.TabIndex = 1;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(172, 9);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(379, 48);
            this.appNameLabel.TabIndex = 2;
            this.appNameLabel.Text = "Smart Meeting Assistant";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLabel.Location = new System.Drawing.Point(684, 9);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Padding = new System.Windows.Forms.Padding(2);
            this.minimizeLabel.Size = new System.Drawing.Size(30, 29);
            this.minimizeLabel.TabIndex = 1;
            this.minimizeLabel.Text = "--";
            this.minimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(720, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Padding = new System.Windows.Forms.Padding(2);
            this.closeLabel.Size = new System.Drawing.Size(30, 29);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.centerPanel.Controls.Add(this.updateConfigButton);
            this.centerPanel.Controls.Add(this.MinCharToComputeMOMTextBox);
            this.centerPanel.Controls.Add(this.SpeechRegionTextBox);
            this.centerPanel.Controls.Add(this.ConfigLabel2);
            this.centerPanel.Controls.Add(this.configLabel1);
            this.centerPanel.Controls.Add(this.viewMOMButton);
            this.centerPanel.Controls.Add(this.startNewMeetingButton);
            this.centerPanel.Controls.Add(this.meetingTitleTextBox);
            this.centerPanel.Controls.Add(this.meetingStatusLabel);
            this.centerPanel.Controls.Add(this.pictureBox1);
            this.centerPanel.Controls.Add(this.currentMeetingMOMTextBox);
            this.centerPanel.Controls.Add(this.GridViewDisplay);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(200, 74);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(759, 439);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // viewMOMButton
            // 
            this.viewMOMButton.Location = new System.Drawing.Point(600, 399);
            this.viewMOMButton.Name = "viewMOMButton";
            this.viewMOMButton.Size = new System.Drawing.Size(147, 32);
            this.viewMOMButton.TabIndex = 4;
            this.viewMOMButton.Text = "View MOM";
            this.viewMOMButton.UseVisualStyleBackColor = true;
            this.viewMOMButton.Click += new System.EventHandler(this.viewMOMButton_Click);
            // 
            // startNewMeetingButton
            // 
            this.startNewMeetingButton.Location = new System.Drawing.Point(22, 399);
            this.startNewMeetingButton.Name = "startNewMeetingButton";
            this.startNewMeetingButton.Size = new System.Drawing.Size(147, 32);
            this.startNewMeetingButton.TabIndex = 3;
            this.startNewMeetingButton.Text = "Start New Meeting";
            this.startNewMeetingButton.UseVisualStyleBackColor = true;
            this.startNewMeetingButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // meetingTitleTextBox
            // 
            this.meetingTitleTextBox.AcceptsReturn = true;
            this.meetingTitleTextBox.Location = new System.Drawing.Point(204, 364);
            this.meetingTitleTextBox.Name = "meetingTitleTextBox";
            this.meetingTitleTextBox.Size = new System.Drawing.Size(347, 22);
            this.meetingTitleTextBox.TabIndex = 2;
            this.meetingTitleTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.meetingTitleTextBox_MouseClick);
            this.meetingTitleTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.meetingTitleTextBox_MouseDown);
            // 
            // meetingStatusLabel
            // 
            this.meetingStatusLabel.AutoSize = true;
            this.meetingStatusLabel.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.meetingStatusLabel.Location = new System.Drawing.Point(175, 381);
            this.meetingStatusLabel.Name = "meetingStatusLabel";
            this.meetingStatusLabel.Size = new System.Drawing.Size(412, 25);
            this.meetingStatusLabel.TabIndex = 1;
            this.meetingStatusLabel.Text = "Meeting is being recorded. Click again to stop.";
            this.meetingStatusLabel.Click += new System.EventHandler(this.meetingStatusLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // currentMeetingMOMTextBox
            // 
            this.currentMeetingMOMTextBox.Location = new System.Drawing.Point(0, 0);
            this.currentMeetingMOMTextBox.Multiline = true;
            this.currentMeetingMOMTextBox.Name = "currentMeetingMOMTextBox";
            this.currentMeetingMOMTextBox.Size = new System.Drawing.Size(759, 439);
            this.currentMeetingMOMTextBox.TabIndex = 5;
            // 
            // GridViewDisplay
            // 
            this.GridViewDisplay.AllowUserToAddRows = false;
            this.GridViewDisplay.AllowUserToDeleteRows = false;
            this.GridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewDisplay.Location = new System.Drawing.Point(0, 0);
            this.GridViewDisplay.Name = "GridViewDisplay";
            this.GridViewDisplay.ReadOnly = true;
            this.GridViewDisplay.RowTemplate.Height = 24;
            this.GridViewDisplay.Size = new System.Drawing.Size(759, 439);
            this.GridViewDisplay.TabIndex = 6;
            // 
            // configLabel1
            // 
            this.configLabel1.AutoSize = true;
            this.configLabel1.Location = new System.Drawing.Point(113, 61);
            this.configLabel1.Name = "configLabel1";
            this.configLabel1.Size = new System.Drawing.Size(105, 17);
            this.configLabel1.TabIndex = 7;
            this.configLabel1.Text = "Speech Region";
            this.configLabel1.Click += new System.EventHandler(this.configLabel1_Click);
            // 
            // ConfigLabel2
            // 
            this.ConfigLabel2.AutoSize = true;
            this.ConfigLabel2.Location = new System.Drawing.Point(116, 122);
            this.ConfigLabel2.Name = "ConfigLabel2";
            this.ConfigLabel2.Size = new System.Drawing.Size(201, 17);
            this.ConfigLabel2.TabIndex = 8;
            this.ConfigLabel2.Text = "Minimun Char to Analyse MOM";
            this.ConfigLabel2.Click += new System.EventHandler(this.ConfigLabel2_Click);
            // 
            // SpeechRegionTextBox
            // 
            this.SpeechRegionTextBox.Location = new System.Drawing.Point(433, 55);
            this.SpeechRegionTextBox.Name = "SpeechRegionTextBox";
            this.SpeechRegionTextBox.Size = new System.Drawing.Size(136, 22);
            this.SpeechRegionTextBox.TabIndex = 9;
            this.SpeechRegionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MinCharToComputeMOMTextBox
            // 
            this.MinCharToComputeMOMTextBox.Location = new System.Drawing.Point(433, 116);
            this.MinCharToComputeMOMTextBox.Name = "MinCharToComputeMOMTextBox";
            this.MinCharToComputeMOMTextBox.Size = new System.Drawing.Size(136, 22);
            this.MinCharToComputeMOMTextBox.TabIndex = 10;
            this.MinCharToComputeMOMTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // updateConfigButton
            // 
            this.updateConfigButton.Location = new System.Drawing.Point(323, 259);
            this.updateConfigButton.Name = "updateConfigButton";
            this.updateConfigButton.Size = new System.Drawing.Size(99, 40);
            this.updateConfigButton.TabIndex = 11;
            this.updateConfigButton.Text = "Update";
            this.updateConfigButton.UseVisualStyleBackColor = true;
            this.updateConfigButton.Click += new System.EventHandler(this.updateConfigButton_Click);
            // 
            // SmartMeetingAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 513);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmartMeetingAssistant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button speechToTextButton;
        private System.Windows.Forms.Button configurationButton;
        private System.Windows.Forms.Button analyseMOMButton;
        private System.Windows.Forms.Button viewLogsButton;
        private System.Windows.Forms.Button startMeetingButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label meetingStatusLabel;
        private System.Windows.Forms.TextBox meetingTitleTextBox;
        private System.Windows.Forms.Button viewMOMButton;
        private System.Windows.Forms.Button startNewMeetingButton;
        private System.Windows.Forms.TextBox currentMeetingMOMTextBox;
        private System.Windows.Forms.DataGridView GridViewDisplay;
        private System.Windows.Forms.BindingSource meetingDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button troubleshootingButton;
        private System.Windows.Forms.Label ConfigLabel2;
        private System.Windows.Forms.Label configLabel1;
        private System.Windows.Forms.Button updateConfigButton;
        private System.Windows.Forms.TextBox MinCharToComputeMOMTextBox;
        private System.Windows.Forms.TextBox SpeechRegionTextBox;
    }
}

