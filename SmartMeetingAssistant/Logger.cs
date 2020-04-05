using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMeetingAssistant
{
  public class Logger
    {
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gargg.DESKTOP-8JFPL5Q\source\repos\SmartMeetingAssistant\SmartMeetingAssistant\AppDB.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public void SaveExceptionToLogs(Exception ex)
        {
                cmd = new SqlCommand("insert into ExceptionLogs (ExceptionLogs) values(@ExceptionLogs)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ExceptionLogs",ex.Message);
                var result = cmd.ExecuteNonQuery();
                con.Close();
        }

        public void SaveMeetingLogs(int id,string logs)
        {
            try
            {
                cmd = new SqlCommand("insert into MeetingLogs (MeetingId,LogSummery) values(@MeetingId,@LogSummery)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@MeetingId", id);
                cmd.Parameters.AddWithValue("@LogSummery", logs);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                SaveExceptionToLogs(ex);
            }
        }
    }
}
