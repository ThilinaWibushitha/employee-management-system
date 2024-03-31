namespace Employee_Management_System
{
    partial class Notification_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_form));
            this.pl_full = new System.Windows.Forms.Panel();
            this.lb_heder = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sent = new System.Windows.Forms.Button();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.tb_recipient = new System.Windows.Forms.TextBox();
            this.tb_sender = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_notificaionId = new System.Windows.Forms.TextBox();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.lb_users_id = new System.Windows.Forms.Label();
            this.lb_subjects = new System.Windows.Forms.Label();
            this.lb_recipient = new System.Windows.Forms.Label();
            this.lb_sender = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_content = new System.Windows.Forms.Label();
            this.lb_notificationId = new System.Windows.Forms.Label();
            this.pl_full.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_full
            // 
            this.pl_full.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_full.Controls.Add(this.lb_heder);
            this.pl_full.Controls.Add(this.btn_back);
            this.pl_full.Controls.Add(this.btn_sent);
            this.pl_full.Controls.Add(this.tb_userId);
            this.pl_full.Controls.Add(this.tb_subject);
            this.pl_full.Controls.Add(this.tb_recipient);
            this.pl_full.Controls.Add(this.tb_sender);
            this.pl_full.Controls.Add(this.tb_date);
            this.pl_full.Controls.Add(this.tb_notificaionId);
            this.pl_full.Controls.Add(this.tb_content);
            this.pl_full.Controls.Add(this.lb_users_id);
            this.pl_full.Controls.Add(this.lb_subjects);
            this.pl_full.Controls.Add(this.lb_recipient);
            this.pl_full.Controls.Add(this.lb_sender);
            this.pl_full.Controls.Add(this.lb_date);
            this.pl_full.Controls.Add(this.lb_content);
            this.pl_full.Controls.Add(this.lb_notificationId);
            this.pl_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_full.Location = new System.Drawing.Point(0, 0);
            this.pl_full.Name = "pl_full";
            this.pl_full.Size = new System.Drawing.Size(953, 664);
            this.pl_full.TabIndex = 0;
            // 
            // lb_heder
            // 
            this.lb_heder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_heder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heder.Location = new System.Drawing.Point(0, 0);
            this.lb_heder.Name = "lb_heder";
            this.lb_heder.Size = new System.Drawing.Size(953, 71);
            this.lb_heder.TabIndex = 16;
            this.lb_heder.Text = "Send Notification";
            this.lb_heder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(794, 589);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 45);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sent
            // 
            this.btn_sent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_sent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sent.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sent.Location = new System.Drawing.Point(794, 519);
            this.btn_sent.Name = "btn_sent";
            this.btn_sent.Size = new System.Drawing.Size(107, 45);
            this.btn_sent.TabIndex = 14;
            this.btn_sent.Text = "Sent";
            this.btn_sent.UseVisualStyleBackColor = false;
            this.btn_sent.Click += new System.EventHandler(this.btn_sent_Click);
            // 
            // tb_userId
            // 
            this.tb_userId.Location = new System.Drawing.Point(397, 589);
            this.tb_userId.Multiline = true;
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(355, 45);
            this.tb_userId.TabIndex = 13;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(397, 519);
            this.tb_subject.Multiline = true;
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(355, 45);
            this.tb_subject.TabIndex = 12;
            // 
            // tb_recipient
            // 
            this.tb_recipient.Location = new System.Drawing.Point(397, 445);
            this.tb_recipient.Multiline = true;
            this.tb_recipient.Name = "tb_recipient";
            this.tb_recipient.Size = new System.Drawing.Size(355, 45);
            this.tb_recipient.TabIndex = 11;
            // 
            // tb_sender
            // 
            this.tb_sender.Location = new System.Drawing.Point(397, 374);
            this.tb_sender.Multiline = true;
            this.tb_sender.Name = "tb_sender";
            this.tb_sender.Size = new System.Drawing.Size(355, 45);
            this.tb_sender.TabIndex = 10;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(397, 304);
            this.tb_date.Multiline = true;
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(355, 45);
            this.tb_date.TabIndex = 9;
            // 
            // tb_notificaionId
            // 
            this.tb_notificaionId.Location = new System.Drawing.Point(397, 107);
            this.tb_notificaionId.Multiline = true;
            this.tb_notificaionId.Name = "tb_notificaionId";
            this.tb_notificaionId.Size = new System.Drawing.Size(355, 45);
            this.tb_notificaionId.TabIndex = 7;
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(397, 179);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(355, 95);
            this.tb_content.TabIndex = 8;
            // 
            // lb_users_id
            // 
            this.lb_users_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_users_id.Location = new System.Drawing.Point(251, 591);
            this.lb_users_id.Name = "lb_users_id";
            this.lb_users_id.Size = new System.Drawing.Size(125, 45);
            this.lb_users_id.TabIndex = 6;
            this.lb_users_id.Text = "User ID";
            this.lb_users_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_subjects
            // 
            this.lb_subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subjects.Location = new System.Drawing.Point(251, 519);
            this.lb_subjects.Name = "lb_subjects";
            this.lb_subjects.Size = new System.Drawing.Size(125, 45);
            this.lb_subjects.TabIndex = 5;
            this.lb_subjects.Text = "Subjects";
            this.lb_subjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_recipient
            // 
            this.lb_recipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_recipient.Location = new System.Drawing.Point(251, 445);
            this.lb_recipient.Name = "lb_recipient";
            this.lb_recipient.Size = new System.Drawing.Size(125, 45);
            this.lb_recipient.TabIndex = 4;
            this.lb_recipient.Text = "Recipient";
            this.lb_recipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_sender
            // 
            this.lb_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sender.Location = new System.Drawing.Point(251, 374);
            this.lb_sender.Name = "lb_sender";
            this.lb_sender.Size = new System.Drawing.Size(125, 45);
            this.lb_sender.TabIndex = 3;
            this.lb_sender.Text = "Sender";
            this.lb_sender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_date
            // 
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(251, 304);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(125, 45);
            this.lb_date.TabIndex = 2;
            this.lb_date.Text = "Date";
            this.lb_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_content
            // 
            this.lb_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_content.Location = new System.Drawing.Point(251, 179);
            this.lb_content.Name = "lb_content";
            this.lb_content.Size = new System.Drawing.Size(125, 45);
            this.lb_content.TabIndex = 1;
            this.lb_content.Text = "Content";
            this.lb_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_notificationId
            // 
            this.lb_notificationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notificationId.Location = new System.Drawing.Point(251, 107);
            this.lb_notificationId.Name = "lb_notificationId";
            this.lb_notificationId.Size = new System.Drawing.Size(125, 45);
            this.lb_notificationId.TabIndex = 0;
            this.lb_notificationId.Text = "Notification ID";
            this.lb_notificationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notification_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 664);
            this.Controls.Add(this.pl_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Send Notification";
            this.pl_full.ResumeLayout(false);
            this.pl_full.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_full;
        private System.Windows.Forms.Label lb_notificationId;
        private System.Windows.Forms.Label lb_content;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_sender;
        private System.Windows.Forms.Label lb_recipient;
        private System.Windows.Forms.Label lb_subjects;
        private System.Windows.Forms.Label lb_users_id;
        private System.Windows.Forms.TextBox tb_notificaionId;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button btn_sent;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.TextBox tb_recipient;
        private System.Windows.Forms.TextBox tb_sender;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_heder;
    }
}