using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }


        public bool login(string Email, string Password, string UserType)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Users.userType = @userType AND Users.email = @email AND Users.users_password = @password";

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userType", UserType);
                        command.Parameters.AddWithValue("@email", Email);
                        command.Parameters.AddWithValue("@password", Password);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool resetPassword(String email, String oldPassword, String newPassword)
        {
            try
            {
                string query = "UPDATE Users SET users_password = @newPassword " +
                               "WHERE email = @email";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
