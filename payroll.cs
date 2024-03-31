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
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {
                int payId = int.Parse(tb_payId.Text);
                float basicSalary = float.Parse(tb_basicSalary.Text);
                float totalSalary = float.Parse(tb_totalSalary.Text);
                DateTime payDate = DateTime.Parse(tb_paymentDate.Text);
                int employeeId = int.Parse(tb_employeeId.Text);
                int managerId = int.Parse(tb_managerId.Text);
                Manager payroll = new Manager();
                payroll.salary(payId, basicSalary, totalSalary, payDate, employeeId, managerId);
                MessageBox.Show("successfully","success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ManagerDashbord dashbord = new ManagerDashbord();
            dashbord.Show();
            this.Hide();
        }
    }
}
