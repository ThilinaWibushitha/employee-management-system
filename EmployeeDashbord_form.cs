using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class EmployeeDashbord_form : Form
    {
        public EmployeeDashbord_form()
        {
            InitializeComponent();
        }

        private void btn_request_leave_Click(object sender, EventArgs e)
        {
            Leave_form childleave = new Leave_form();
            childleave.Show();
            this.Hide();
        }

        private void btn_MyProfile_details_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeID =int.Parse(tb_employeeId.Text);
                Employee employee = new Employee();
                DataTable details = employee.GetEmployees(employeeID);
                dgv_details.DataSource = details;
                if (details.Rows.Count == 0)
                {
                    dgv_details.DataSource = null;
                    MessageBox.Show("No values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_form login_back = new Login_form();
            login_back.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Notification_View notification_view = new Notification_View();
            notification_view.Show();
            this.Hide();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString);
            try
            {
                int payId = int.Parse(tb_payId.Text);
                string query = "SELECT * FROM Payroll WHERE payment_id=@payId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@payId", payId);
                conn.Open();

                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());

                dgv_details.DataSource = dataTable;
                if (dataTable.Rows.Count == 0)
                {
                    dgv_details.DataSource = null;
                    MessageBox.Show("No values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_attendence_Click(object sender, EventArgs e)
        {
            Attendence_form attendence = new Attendence_form();
            attendence.Show();
            this.Hide();
        }

        private void lb_employee_Click(object sender, EventArgs e)
        {

        }
    }
}
