using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SmartMeetingAssistant
{
    class DataAccess
    {
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gargg.DESKTOP-8JFPL5Q\source\repos\SmartMeetingAssistant\SmartMeetingAssistant\AppDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public int SaveMeetingData(string title, DateTime startDate, string text, string mom, DateTime endDate)
        {
            try
            {
                cmd = new SqlCommand("insert into MeetingData (Title,StartDate,MOM,MeetingText,EndDate) OUTPUT INSERTED.ID values(@Title,@StartDate,@MOM,@MeetingText,@EndDate)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@MOM", mom);
                cmd.Parameters.AddWithValue("@MeetingText", text);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                var result = cmd.ExecuteScalar();
                con.Close();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return 0;
            }
        }

        public DataTable GetAllExceptionLogData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from ExceptionLogs", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return null;
            }
        }

        public DataTable GetAllMeetingData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from MeetingData", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return null;
            }
        }

        public DataTable GetAllMeetingLogsData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from MeetingLogs", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return null;
            }
        }

        public List<KeyValuePair<string, string>> GetConfiguration()
        {
            List<KeyValuePair<string, string>> configuration = new List<KeyValuePair<string, string>>();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Configuration", con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (rdr.Read())
                    {
                        var myString = rdr.GetString(0);
                        configuration.Insert(i, new KeyValuePair<string, string>(rdr.GetString(0), rdr.GetString(1)));
                        i++;
                    }
                }
                con.Close();
                return configuration;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return null;
            }
        }

        public bool UpdateConfiguration(string mincharLimit,string region)
        {
            try
            {
                cmd = new SqlCommand(@"UPDATE Configuration SET ConfigValue = @minLimit Where ConfigKey=@key", con);
                con.Open();
                cmd.Parameters.AddWithValue("@minLimit", mincharLimit);
                cmd.Parameters.AddWithValue("@key", "MinCharToComputeMOM");
                var result1 = cmd.ExecuteNonQuery();
                con.Close();
                cmd = new SqlCommand(@"UPDATE Configuration SET ConfigValue = @region Where ConfigKey=@key2", con);
                con.Open();
                cmd.Parameters.AddWithValue("@region", region);
                cmd.Parameters.AddWithValue("@key2", "SpeechRegion");
                var result = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.SaveExceptionToLogs(ex);
                return false;
            }
        }

    }
}
