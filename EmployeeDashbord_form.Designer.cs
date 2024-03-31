namespace Employee_Management_System
{
    partial class EmployeeDashbord_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashbord_form));
            this.pl_left = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_request_leave = new System.Windows.Forms.Button();
            this.btn_attendence = new System.Windows.Forms.Button();
            this.btn_MyProfile_details = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.Notification = new System.Windows.Forms.Button();
            this.pb_employee = new System.Windows.Forms.PictureBox();
            this.pl_right = new System.Windows.Forms.Panel();
            this.tb_payId = new System.Windows.Forms.TextBox();
            this.lb_payId = new System.Windows.Forms.Label();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.lb_employee = new System.Windows.Forms.Label();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.pl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).BeginInit();
            this.pl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_left.Controls.Add(this.btn_cancel);
            this.pl_left.Controls.Add(this.btn_back);
            this.pl_left.Controls.Add(this.btn_request_leave);
            this.pl_left.Controls.Add(this.btn_attendence);
            this.pl_left.Controls.Add(this.btn_MyProfile_details);
            this.pl_left.Controls.Add(this.btn_pay);
            this.pl_left.Controls.Add(this.Notification);
            this.pl_left.Controls.Add(this.pb_employee);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(321, 659);
            this.pl_left.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(0, 596);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(321, 60);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(0, 536);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(321, 60);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_request_leave
            // 
            this.btn_request_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_request_leave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_request_leave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_request_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_request_leave.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_request_leave.Location = new System.Drawing.Point(0, 476);
            this.btn_request_leave.Name = "btn_request_leave";
            this.btn_request_leave.Size = new System.Drawing.Size(321, 60);
            this.btn_request_leave.TabIndex = 1;
            this.btn_request_leave.Text = "Request Leave";
            this.btn_request_leave.UseVisualStyleBackColor = false;
            this.btn_request_leave.Click += new System.EventHandler(this.btn_request_leave_Click);
            // 
            // btn_attendence
            // 
            this.btn_attendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_attendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_attendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendence.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_attendence.Location = new System.Drawing.Point(0, 416);
            this.btn_attendence.Name = "btn_attendence";
            this.btn_attendence.Size = new System.Drawing.Size(321, 60);
            this.btn_attendence.TabIndex = 7;
            this.btn_attendence.Text = "Attendence";
            this.btn_attendence.UseVisualStyleBackColor = false;
            this.btn_attendence.Click += new System.EventHandler(this.btn_attendence_Click);
            // 
            // btn_MyProfile_details
            // 
            this.btn_MyProfile_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_MyProfile_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MyProfile_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MyProfile_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyProfile_details.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_MyProfile_details.Location = new System.Drawing.Point(0, 356);
            this.btn_MyProfile_details.Name = "btn_MyProfile_details";
            this.btn_MyProfile_details.Size = new System.Drawing.Size(321, 60);
            this.btn_MyProfile_details.TabIndex = 2;
            this.btn_MyProfile_details.Text = "My Profile Details";
            this.btn_MyProfile_details.UseVisualStyleBackColor = false;
            this.btn_MyProfile_details.Click += new System.EventHandler(this.btn_MyProfile_details_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_pay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pay.Location = new System.Drawing.Point(0, 296);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(321, 60);
            this.btn_pay.TabIndex = 5;
            this.btn_pay.Text = "My Salary";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // Notification
            // 
            this.Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.Notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.ForeColor = System.Drawing.SystemColors.Control;
            this.Notification.Location = new System.Drawing.Point(0, 236);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(321, 60);
            this.Notification.TabIndex = 6;
            this.Notification.Text = "Notification";
            this.Notification.UseVisualStyleBackColor = false;
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // pb_employee
            // 
            this.pb_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_employee.Image = global::Employee_Management_System.Properties.Resources.pngegg__1_;
            this.pb_employee.Location = new System.Drawing.Point(0, 0);
            this.pb_employee.Name = "pb_employee";
            this.pb_employee.Size = new System.Drawing.Size(321, 236);
            this.pb_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_employee.TabIndex = 0;
            this.pb_employee.TabStop = false;
            // 
            // pl_right
            // 
            this.pl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_right.Controls.Add(this.tb_payId);
            this.pl_right.Controls.Add(this.lb_payId);
            this.pl_right.Controls.Add(this.tb_employeeId);
            this.pl_right.Controls.Add(this.lb_employee);
            this.pl_right.Controls.Add(this.dgv_details);
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_right.Location = new System.Drawing.Point(321, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(731, 659);
            this.pl_right.TabIndex = 1;
            // 
            // tb_payId
            // 
            this.tb_payId.Location = new System.Drawing.Point(300, 106);
            this.tb_payId.Multiline = true;
            this.tb_payId.Name = "tb_payId";
            this.tb_payId.Size = new System.Drawing.Size(222, 36);
            this.tb_payId.TabIndex = 4;
            // 
            // lb_payId
            // 
            this.lb_payId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_payId.Location = new System.Drawing.Point(146, 106);
            this.lb_payId.Name = "lb_payId";
            this.lb_payId.Size = new System.Drawing.Size(133, 36);
            this.lb_payId.TabIndex = 3;
            this.lb_payId.Text = "Pay ID";
            this.lb_payId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(300, 35);
            this.tb_employeeId.Multiline = true;
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(222, 36);
            this.tb_employeeId.TabIndex = 2;
            // 
            // lb_employee
            // 
            this.lb_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employee.Location = new System.Drawing.Point(146, 35);
            this.lb_employee.Name = "lb_employee";
            this.lb_employee.Size = new System.Drawing.Size(133, 36);
            this.lb_employee.TabIndex = 1;
            this.lb_employee.Text = "Employee ID";
            this.lb_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_employee.Click += new System.EventHandler(this.lb_employee_Click);
            // 
            // dgv_details
            // 
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Location = new System.Drawing.Point(0, 209);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 62;
            this.dgv_details.RowTemplate.Height = 28;
            this.dgv_details.Size = new System.Drawing.Size(805, 450);
            this.dgv_details.TabIndex = 0;
            // 
            // EmployeeDashbord_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1052, 659);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDashbord_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Employee Dashbord";
            this.pl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).EndInit();
            this.pl_right.ResumeLayout(false);
            this.pl_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.PictureBox pb_employee;
        private System.Windows.Forms.Button btn_request_leave;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_MyProfile_details;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.Label lb_employee;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button Notification;
        private System.Windows.Forms.TextBox tb_payId;
        private System.Windows.Forms.Label lb_payId;
        private System.Windows.Forms.Button btn_attendence;
    }
}