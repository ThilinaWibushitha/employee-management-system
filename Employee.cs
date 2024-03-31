using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Employee_Management_System
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
        //
        public DataTable GetEmployees(int employeeId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Employee WHERE employee_id = @employeeId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetEmployees(object employeeId)
        {
            throw new NotImplementedException();
        }
        public void enterAttendence(int attendenceId, string status, DateTime timeIn, DateTime timeOut, int employeeId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Attendence (attendence_id,status_in_employee,time_in,time_out,employee_id) VALUES (@attendenceId,@status,@timeIn,@timeOut,@employeeId)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@attendenceId", attendenceId);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@timeIn", timeIn);
                    cmd.Parameters.AddWithValue("@timeOut", timeOut);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
