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
    public partial class emplNewProfileCreate : Form
    {
        public emplNewProfileCreate()
        {
            InitializeComponent();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(tb_employeeId.Text) ||
                    string.IsNullOrWhiteSpace(tb_firstName.Text) ||
                    string.IsNullOrWhiteSpace(tb_lName.Text) ||
                    string.IsNullOrWhiteSpace(tb_dob.Text))
                {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

                int employeeID = int.Parse(tb_employeeId.Text);
                String fName = tb_firstName.Text;
                String lName = tb_lName.Text;
                DateTime dob = DateTime.Parse(tb_dob.Text);
                // Create employee
                Admin createemp = new Admin();
                createemp.createEmployee(employeeID, fName, lName, dob);
                MessageBox.Show("Create Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashbord empBack = new AdminDashbord();
            empBack.Show();
            this.Hide();
        }
    }
}
