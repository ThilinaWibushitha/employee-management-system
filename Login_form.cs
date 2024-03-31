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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email_log.Text;
            string password = tb_password_log.Text;
            string user_type =cb_select.Text;
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(user_type))
                {
                    MessageBox.Show("Please enter email, password, and select user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Login log = new Login();
                bool loginSuccessful = log.login(email, password, user_type);
                if (loginSuccessful)
                {
                    MessageBox.Show("Login Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (user_type == "Manager")
                    {
                        ManagerDashbord managerDashboard = new ManagerDashbord();
                        managerDashboard.Show();
                        this.Hide();
                    }
                    else if (user_type == "Employee")
                    {
                        EmployeeDashbord_form employeeDashboard = new EmployeeDashbord_form();
                        employeeDashboard.Show();
                        this.Hide();
                    }
                    else if (user_type == "Admin")
                    {
                        AdminDashbord adminDashboard = new AdminDashbord();
                        adminDashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_email_log.Clear();
                    tb_password_log.Clear();
                    tb_email_log.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void llb_Forgotten_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword_form resetPassword_Form = new ResetPassword_form();
            resetPassword_Form.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserDashbord userDashbord = new UserDashbord();
            userDashbord.Show();
            this.Hide();
        }
    }
}
