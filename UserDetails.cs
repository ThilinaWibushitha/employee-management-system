using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Employee_Management_System
{
    public partial class UserDetails : Form
    {
       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString);
        public UserDetails()
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(tb_id.Text);
                string query = "SELECT Users.department, Users.f_name, Users.l_name,Users.userType, Users.users_id FROM Users WHERE Users.users_id = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserDashbord userDashbord = new UserDashbord();
            userDashbord.Show();
            this.Hide();
        }
    }
}
