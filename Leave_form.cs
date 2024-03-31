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
    public partial class Leave_form : Form
    {
        public Leave_form()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EmployeeDashbord_form employeedashbord = new EmployeeDashbord_form();
            employeedashbord.Show();
            this.Hide();
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            int requestId = int.Parse(tb_requestId.Text);
            int employeeId = int.Parse(tb_employeeId.Text);
            int managerId = int.Parse(tb_managerId.Text);
            string leaveType = cb_leaveType.Text;
            string reason = tb_reason.Text;
            DateTime start = DateTime.Parse(tb_startDate.Text);
            DateTime end = DateTime.Parse(tb_endDate.Text);
            try
            {
                Leave request = new Leave();
                bool isRequestSuccessful = request.request_leave(requestId, employeeId, managerId, start, end, reason, leaveType, "Pending");
                if (isRequestSuccessful)
                {
                    MessageBox.Show("Leave request submitted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to submit leave request.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting leave request: " + ex.Message);
            }
        }

    }
}
