using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class Notification
    {
        int notificationId { get; set; }
      
        //
        private string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
        //
        public void sendNotification(int notificationId, string content, DateTime date, string sender, string recipient, string subjects, int users_id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String query = "INSERT INTO Notifications (notification_id, [content], send_date_time, sender, recipient, subjects, users_id)  VALUES (@notificationId, @content, @sendDatetime, @sender, @recipient, @subjects, @users_id)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@notificationId", notificationId);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@sendDatetime", date);
                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@recipient", recipient);
                cmd.Parameters.AddWithValue("@subjects", subjects);
                cmd.Parameters.AddWithValue("@users_id", users_id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
