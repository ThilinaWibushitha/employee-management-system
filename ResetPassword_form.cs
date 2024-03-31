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
    public partial class ResetPassword_form : Form
    {
        public ResetPassword_form()
        {
            InitializeComponent();
        }

        private void btn_conform_Click(object sender, EventArgs e)
        {
            String email = tb_email.Text;
            String oldPassword = tb_oldPassword.Text;
            String newPassword = tb_newPassword.Text;
            try
            {
                Login reset_password = new Login();
                bool success = reset_password.resetPassword(email, oldPassword, newPassword);
                if (success)
                {
                    MessageBox.Show("Password Reset Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_oldPassword.Clear();
                    tb_newPassword.Clear();
                    tb_newPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to reset password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login_form login_Form = new Login_form();
            login_Form.Close();
            this.Close();
        }
    }
}
