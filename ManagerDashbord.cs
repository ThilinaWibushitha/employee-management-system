using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class ManagerDashbord : Form
    {
        public ManagerDashbord()
        {
            InitializeComponent();
        }

        private void btn_approveLeave_Click(object sender, EventArgs e)
        {
            int requestId = int.Parse(tb_requestId.Text);
            try
            {
                Leave leave = new Leave();
                bool leave_approve = leave.approve_leave(requestId);
                if (leave_approve)
                {
                    MessageBox.Show("Leave Request Approve","Approve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_leaveDetails.DataSource = null;
                    MessageBox.Show("No pending leave requests.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rejectLeave_Click(object sender, EventArgs e)
        {
            int requestID = int.Parse(tb_requestId.Text);
            try
            {
                Leave leave_rejec = new Leave();
                bool leave_reject_meth = leave_rejec.reject_leave(requestID);
                if (leave_reject_meth)
                {
                    MessageBox.Show("Leave Request Reject", "Reject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_leaveDetails.DataSource = null;
                    MessageBox.Show("No pending leave requests.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString);
            try
            {

                string query = "SELECT request_id, employee_id, leave_type, reason, start_up_date, end_date status FROM Leave WHERE status = 'pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());

                dgv_leaveDetails.DataSource = dataTable;
                if (dataTable.Rows.Count == 0)
                {
                    dgv_leaveDetails.DataSource = null;
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

        private void btn_createSalary_Click(object sender, EventArgs e)
        {
            payroll pay = new payroll();
            pay.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_form login = new Login_form();
            login.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}    
