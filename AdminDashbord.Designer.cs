namespace Employee_Management_System
{
    partial class AdminDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashbord));
            this.pl_left = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_viewProfile = new System.Windows.Forms.Button();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.btn_notification = new System.Windows.Forms.Button();
            this.pb_admin = new System.Windows.Forms.PictureBox();
            this.pl_right = new System.Windows.Forms.Panel();
            this.dgv_employee = new System.Windows.Forms.DataGridView();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.ln_employeeId = new System.Windows.Forms.Label();
            this.lb_headline = new System.Windows.Forms.Label();
            this.btn_employeeAttendence = new System.Windows.Forms.Button();
            this.pl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_admin)).BeginInit();
            this.pl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_left.Controls.Add(this.btn_cancel);
            this.pl_left.Controls.Add(this.btn_back);
            this.pl_left.Controls.Add(this.btn_create);
            this.pl_left.Controls.Add(this.btn_employeeAttendence);
            this.pl_left.Controls.Add(this.btn_delete);
            this.pl_left.Controls.Add(this.btn_update);
            this.pl_left.Controls.Add(this.btn_viewProfile);
            this.pl_left.Controls.Add(this.btn_createUser);
            this.pl_left.Controls.Add(this.btn_notification);
            this.pl_left.Controls.Add(this.pb_admin);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(296, 685);
            this.pl_left.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(0, 617);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(296, 65);
            this.btn_cancel.TabIndex = 6;
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
            this.btn_back.Location = new System.Drawing.Point(0, 552);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(296, 65);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_create.Location = new System.Drawing.Point(0, 487);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(296, 65);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create Profile";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(0, 357);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(296, 65);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete Profile";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Location = new System.Drawing.Point(0, 292);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(296, 65);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Employee Profile Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_viewProfile
            // 
            this.btn_viewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_viewProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_viewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewProfile.Location = new System.Drawing.Point(0, 227);
            this.btn_viewProfile.Name = "btn_viewProfile";
            this.btn_viewProfile.Size = new System.Drawing.Size(296, 65);
            this.btn_viewProfile.TabIndex = 1;
            this.btn_viewProfile.Text = "Employee Profile";
            this.btn_viewProfile.UseVisualStyleBackColor = false;
            this.btn_viewProfile.Click += new System.EventHandler(this.btn_viewProfile_Click);
            // 
            // btn_createUser
            // 
            this.btn_createUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_createUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_createUser.Location = new System.Drawing.Point(0, 162);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(296, 65);
            this.btn_createUser.TabIndex = 7;
            this.btn_createUser.Text = "Create User";
            this.btn_createUser.UseVisualStyleBackColor = false;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // btn_notification
            // 
            this.btn_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_notification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_notification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notification.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_notification.Location = new System.Drawing.Point(0, 97);
            this.btn_notification.Name = "btn_notification";
            this.btn_notification.Size = new System.Drawing.Size(296, 65);
            this.btn_notification.TabIndex = 8;
            this.btn_notification.Text = "Send Notification";
            this.btn_notification.UseVisualStyleBackColor = false;
            this.btn_notification.Click += new System.EventHandler(this.btn_notification_Click);
            // 
            // pb_admin
            // 
            this.pb_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_admin.Image = global::Employee_Management_System.Properties.Resources.admin_icon;
            this.pb_admin.Location = new System.Drawing.Point(0, 0);
            this.pb_admin.Name = "pb_admin";
            this.pb_admin.Size = new System.Drawing.Size(296, 97);
            this.pb_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_admin.TabIndex = 0;
            this.pb_admin.TabStop = false;
            // 
            // pl_right
            // 
            this.pl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_right.Controls.Add(this.dgv_employee);
            this.pl_right.Controls.Add(this.tb_employeeId);
            this.pl_right.Controls.Add(this.ln_employeeId);
            this.pl_right.Controls.Add(this.lb_headline);
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_right.Location = new System.Drawing.Point(296, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(718, 685);
            this.pl_right.TabIndex = 1;
            // 
            // dgv_employee
            // 
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_employee.Location = new System.Drawing.Point(0, 361);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.RowHeadersWidth = 62;
            this.dgv_employee.RowTemplate.Height = 28;
            this.dgv_employee.Size = new System.Drawing.Size(718, 324);
            this.dgv_employee.TabIndex = 3;
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(276, 127);
            this.tb_employeeId.Multiline = true;
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(273, 45);
            this.tb_employeeId.TabIndex = 2;
            // 
            // ln_employeeId
            // 
            this.ln_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_employeeId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ln_employeeId.Location = new System.Drawing.Point(76, 127);
            this.ln_employeeId.Name = "ln_employeeId";
            this.ln_employeeId.Size = new System.Drawing.Size(194, 113);
            this.ln_employeeId.TabIndex = 1;
            this.ln_employeeId.Text = "Employee ID\r\n(Serach Profile,Delete Profile and Attendence Check )\r\n\r\n";
            this.ln_employeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_headline
            // 
            this.lb_headline.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headline.Location = new System.Drawing.Point(0, 0);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(718, 57);
            this.lb_headline.TabIndex = 0;
            this.lb_headline.Text = "Admin Dashbord";
            this.lb_headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_employeeAttendence
            // 
            this.btn_employeeAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_employeeAttendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employeeAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_employeeAttendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employeeAttendence.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_employeeAttendence.Location = new System.Drawing.Point(0, 422);
            this.btn_employeeAttendence.Name = "btn_employeeAttendence";
            this.btn_employeeAttendence.Size = new System.Drawing.Size(296, 65);
            this.btn_employeeAttendence.TabIndex = 9;
            this.btn_employeeAttendence.Text = "Employee Attendence";
            this.btn_employeeAttendence.UseVisualStyleBackColor = false;
            this.btn_employeeAttendence.Click += new System.EventHandler(this.btn_employeeAttendence_Click);
            // 
            // AdminDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1014, 685);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Admin Dashbord";
            this.pl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_admin)).EndInit();
            this.pl_right.ResumeLayout(false);
            this.pl_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.PictureBox pb_admin;
        private System.Windows.Forms.Button btn_viewProfile;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.Label ln_employeeId;
        private System.Windows.Forms.Label lb_headline;
        private System.Windows.Forms.DataGridView dgv_employee;
        private System.Windows.Forms.Button btn_createUser;
        private System.Windows.Forms.Button btn_notification;
        private System.Windows.Forms.Button btn_employeeAttendence;
    }
}