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
    public partial class Notification_form : Form
    {
        public Notification_form()
        {
            InitializeComponent();
        }

        private void btn_sent_Click(object sender, EventArgs e)
        {
            try
            {
                int notificationId = int.Parse(tb_notificaionId.Text);
                string content = tb_content.Text;
                DateTime date = DateTime.Parse(tb_date.Text);
                string senderName = tb_sender.Text;
                string recipient = tb_recipient.Text;
                string subject = tb_subject.Text;
                int userId = int.Parse(tb_userId.Text);

                Notification notification = new Notification();
                notification.sendNotification(notificationId, content, date, senderName, recipient, subject, userId);
                MessageBox.Show("Sent Message Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail to send" + ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashbord back = new AdminDashbord();
            back.Show();
            this.Hide();
        }
    }
}
