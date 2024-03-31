using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Employee_Management_System
{
    public class Admin
    {
        public int EmployeeId { get; set; }
        //
        private string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
        //
        public DataTable EmployeeProfile(int EmployeeId)
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
                string query = "SELECT * FROM Users FULL OUTER JOIN Employee ON Users.users_id = Employee.employee_id WHERE Employee.employee_id = @employee_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", EmployeeId);
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // or return new DataTable(); depending on how you want to handle the error
            }
        }
        //
        public void updateEmployees(int employeeId, int userId, String firthName, String lastName, DateTime dob)
        {
          
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                    con.Open();
                    String query = "UPDATE Employee SET date_of_birth=@dob, f_name=@firstName, l_name=@lastName, users_id=@UserId WHERE employee_id=@employeeId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@firstName", firthName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);

                    cmd.ExecuteNonQuery();
                }

            }

        }
        //
        public void deleteEmployee(int employeeId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open() ;
                String query = "DELETE FROM Employee WHERE employee_id =@employeeId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
                
            }
        }
        public void createEmployee(int employeeId, string firstName, string lastName, DateTime dob)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String query = "SET IDENTITY_INSERT Employee ON; INSERT INTO Employee (employee_id, f_name, l_name, date_of_birth) VALUES (@employeeId, @fName, @lname, @dob); SET IDENTITY_INSERT Employee OFF;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void userCreate(int userId, string firstName, string lastName, string email, string password, string department, string userType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String query = "INSERT INTO Users (users_id, f_name, l_name, email, users_password, department, userType) VALUES (@userId, @fName, @lName, @email, @password, @department, @userType)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@userType", userType);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteuser(int userId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String query = "DELETE FROM Users WHERE users_id =@userId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable EmployeeAttendence(int EmployeeId)
        {
            try
            {
                DataTable dt = new DataTable();
                string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
                string query = "SELECT attendence_id,status_in_employee,time_in,time_out,employee_id FROM Attendence WHERE employee_id = @employee_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employee_id", EmployeeId);
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // or return new DataTable(); depending on how you want to handle the error
            }
        }

    }
}

