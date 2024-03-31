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
    public partial class Notification_View : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["my_db"].ConnectionString);
        public Notification_View()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(tb_userId.Text);
                string query = "SELECT * FROM Notifications WHERE users_id = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                con.Open();

                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());

                dgv_notification.DataSource = dataTable;
                if (dataTable.Rows.Count == 0)
                {
                    dgv_notification.DataSource = null;
                    MessageBox.Show("No values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EmployeeDashbord_form notifiBack = new EmployeeDashbord_form();
            notifiBack.Show();
            this.Hide();
        }
    }
}
