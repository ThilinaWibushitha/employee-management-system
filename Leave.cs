using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public class Leave
    {
        public int EmployeeId { get; set; }
        public int RequestId { get; set; }
        public int ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string LeaveType { get; set; }
        public string Status { get; set; }
        //
        public bool request_leave(int RequestId, int EmployeeId, int ManagerId, DateTime StarDate, DateTime EndDate, string Reason, String LeaveType, String Status)
        {
            try
            {
                string query = "INSERT INTO Leave(request_id, employee_id, manager_id, leave_type, reason, start_up_date, end_date, status) VALUES (@request_id, @employee_id, @manager_id, @leave_type, @reason, @start_up_date, @end_date, @status)";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@request_id", RequestId);
                        command.Parameters.AddWithValue("@employee_id", EmployeeId);
                        command.Parameters.AddWithValue("@manager_id", ManagerId);
                        command.Parameters.AddWithValue("@leave_type", LeaveType);
                        command.Parameters.AddWithValue("@reason", Reason);
                        command.Parameters.AddWithValue("@start_up_date", StarDate);
                        command.Parameters.AddWithValue("@end_date", EndDate);
                        command.Parameters.AddWithValue("@status", Status);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Requesting Leave " + ex.Message);
                return false;
            }
        }
        public bool approve_leave(int RequestId)
        {
            try
            {
                String query = "UPDATE Leave SET status ='Approve' WHERE request_id =@request_id";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@request_id", RequestId);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Approving Leave" + ex.Message);
                return false;
            }
        }
        public bool reject_leave(int RequestId)
        {
            try
            {
                String query = "UPDATE Leave SET status ='Reject' WHERE request_id =@request_id";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@request_id", RequestId);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Rejecting Leave" + ex.Message);
                return false;
            }

        }
       
        

    }
}
