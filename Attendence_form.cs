using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Attendence_form : Form
    {
        public Attendence_form()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                int attendenceId;
                if (!int.TryParse(tb_attendenceId.Text, out attendenceId))
                {
                    MessageBox.Show("Invalid attendance ID.");
                    return;
                }

                string status = tb_status.Text;

                DateTime timeIn;
                if (!DateTime.TryParse(tb_timeIn.Text, out timeIn))
                {
                    MessageBox.Show("Invalid time in format.");
                    return;
                }

                DateTime timeOut;
                if (!DateTime.TryParse(tb_timeOut.Text, out timeOut))
                {
                    MessageBox.Show("Invalid time out format.");
                    return;
                }

                int employeeId;
                if (!int.TryParse(tb_employeeId.Text, out employeeId))
                {
                    MessageBox.Show("Invalid employee ID.");
                    return;
                }

                Employee employee = new Employee();
                employee.enterAttendence(attendenceId, status, timeIn, timeOut, employeeId);
                MessageBox.Show("Enter Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EmployeeDashbord_form backemp = new EmployeeDashbord_form();
            backemp.Show();
            this.Hide();
        }
    }
}
