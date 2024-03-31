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
    public partial class CreateUserAccount : Form
    {
        public CreateUserAccount()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(tb_userId.Text);
                string fName = tb_fName.Text;
                string lname = tb_lName.Text;
                string email = tb_email.Text;
                string password = tb_password.Text;
                string department = tb_department.Text;
                string userType = tb_userType.Text;

                Admin user = new Admin();
                user.userCreate(userId, fName, lname, email, password, department, userType);
                MessageBox.Show("Create Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int userId =int.Parse(tb_userId.Text);
                Admin deleteUser = new Admin();
                deleteUser.deleteuser(userId);
                MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashbord createBack = new AdminDashbord();
            createBack.Show();
            this.Hide();
        }
    }
}
