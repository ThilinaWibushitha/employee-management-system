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
    public partial class EmployeeUpadateDetails : Form
    {
        public EmployeeUpadateDetails()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                int employeeId = int.Parse(tb_employeeId.Text);
                int UserId = int.Parse(tb_userId.Text);
                String fName = tb_fName.Text;
                String lName = tb_lName.Text;
                DateTime dob = DateTime.Parse(tb_dob.Text);

                Admin admin = new Admin();
                admin.updateEmployees(employeeId, UserId, fName, lName, dob);
                MessageBox.Show("Employee Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashbord adminback = new AdminDashbord();
            adminback.Show();
            this.Hide();
        }
    }
}
