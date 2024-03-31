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
    public partial class UserDashbord : Form
    {
        public UserDashbord()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString);

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            String email, password;
            email = tb_email.Text;
            password = tb_password.Text;

            try
            {
                string query = "SELECT * FROM Users WHERE email = '" + tb_email.Text.Trim() + "' AND users_password='" + tb_password.Text.Trim() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    email = tb_email.Text;
                    password = tb_password.Text;

                    UserDetails employee = new UserDetails();
                    employee.Show();
                    this.Hide();
                    MessageBox.Show("Login Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Login Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_email.Clear();
                    tb_password.Clear();

                    tb_email.Focus();
                }
            }
            catch
            {

                MessageBox.Show("Error!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_main_Click(object sender, EventArgs e)
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
