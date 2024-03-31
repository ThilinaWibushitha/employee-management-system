namespace Employee_Management_System
{
    partial class Notification_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_View));
            this.pl_full = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.dgv_notification = new System.Windows.Forms.DataGridView();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.lb_userId = new System.Windows.Forms.Label();
            this.pl_full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notification)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_full
            // 
            this.pl_full.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_full.Controls.Add(this.btn_back);
            this.pl_full.Controls.Add(this.btn_check);
            this.pl_full.Controls.Add(this.dgv_notification);
            this.pl_full.Controls.Add(this.tb_userId);
            this.pl_full.Controls.Add(this.lb_userId);
            this.pl_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_full.Location = new System.Drawing.Point(0, 0);
            this.pl_full.Name = "pl_full";
            this.pl_full.Size = new System.Drawing.Size(1058, 594);
            this.pl_full.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(763, 76);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 50);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_check.Location = new System.Drawing.Point(537, 75);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(199, 50);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "Check Notification";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dgv_notification
            // 
            this.dgv_notification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notification.Location = new System.Drawing.Point(0, 290);
            this.dgv_notification.Name = "dgv_notification";
            this.dgv_notification.RowHeadersWidth = 62;
            this.dgv_notification.RowTemplate.Height = 28;
            this.dgv_notification.Size = new System.Drawing.Size(1058, 304);
            this.dgv_notification.TabIndex = 2;
            // 
            // tb_userId
            // 
            this.tb_userId.Location = new System.Drawing.Point(258, 76);
            this.tb_userId.Multiline = true;
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(251, 46);
            this.tb_userId.TabIndex = 1;
            // 
            // lb_userId
            // 
            this.lb_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userId.Location = new System.Drawing.Point(147, 76);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(105, 46);
            this.lb_userId.TabIndex = 0;
            this.lb_userId.Text = "User ID";
            this.lb_userId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notification_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 594);
            this.Controls.Add(this.pl_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Notification";
            this.pl_full.ResumeLayout(false);
            this.pl_full.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_full;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.Label lb_userId;
        private System.Windows.Forms.DataGridView dgv_notification;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_back;
    }
}