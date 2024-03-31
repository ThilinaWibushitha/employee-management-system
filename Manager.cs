using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Employee_Management_System
{
    public class Manager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["my_db"].ConnectionString;
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        //
        public void salary(int payId, float basicSalary, float totalSalary, DateTime paymentDate, int employeeId, int managerId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String query = "INSERT INTO Payroll (payment_id,basic_salary,payment,payment_date,employee_id,manager_id) VALUES (@paymentId,@basicSalary,@totalSalary,@paymentDate,@employeeId,@managerId)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@paymentId", payId);
                    cmd.Parameters.AddWithValue("@basicSalary", basicSalary);
                    cmd.Parameters.AddWithValue("@totalSalary", totalSalary);
                    cmd.Parameters.AddWithValue("@paymentDate", paymentDate);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
       






    }
}
