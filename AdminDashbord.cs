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
    public partial class AdminDashbord : Form
    {
        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void btn_viewProfile_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId;
                if (!int.TryParse(tb_employeeId.Text, out employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.");
                    return;
                }

                Admin admin_view = new Admin();
                DataTable dt = admin_view.EmployeeProfile(employeeId);
                dgv_employee.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgv_employee.Show();
                }
                else
                {
                    dgv_employee.DataSource = null;
                    MessageBox.Show("No employee profiles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            EmployeeUpadateDetails details = new EmployeeUpadateDetails();
            details.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = int.Parse(tb_employeeId.Text);
                Admin delete_emp = new Admin();
                delete_emp.deleteEmployee(employeeId);
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show("Error:" +ex.Message);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            emplNewProfileCreate newPrfile = new emplNewProfileCreate();
            newPrfile.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_form adminlog = new Login_form();
            adminlog.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {
            CreateUserAccount newUser = new CreateUserAccount();
            newUser.Show();
            this.Hide();
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            Notification_form notification = new Notification_form();
            notification.Show();
            this.Hide();
        }

        private void btn_employeeAttendence_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(tb_employeeId.Text);
            Admin checkAttendence = new Admin();
            DataTable dt = checkAttendence.EmployeeAttendence(employeeId);
            dgv_employee.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv_employee.Show();
            }
            else
            {
                dgv_employee.DataSource = null;
                MessageBox.Show("No employee profiles.");
            }
        }
    }
}
