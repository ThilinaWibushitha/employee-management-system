namespace Employee_Management_System
{
    partial class UserDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashbord));
            this.pl_left = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.pb_employee = new System.Windows.Forms.PictureBox();
            this.pl_right = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.pb_email = new System.Windows.Forms.PictureBox();
            this.lb_right = new System.Windows.Forms.Label();
            this.pl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).BeginInit();
            this.pl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_left.Controls.Add(this.btn_cancel);
            this.pl_left.Controls.Add(this.btn_main);
            this.pl_left.Controls.Add(this.pb_employee);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(396, 628);
            this.pl_left.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(0, 403);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(396, 60);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_main.Location = new System.Drawing.Point(0, 343);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(396, 60);
            this.btn_main.TabIndex = 3;
            this.btn_main.Text = "Main Login";
            this.btn_main.UseVisualStyleBackColor = false;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // pb_employee
            // 
            this.pb_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_employee.Image = global::Employee_Management_System.Properties.Resources.employee;
            this.pb_employee.Location = new System.Drawing.Point(0, 0);
            this.pb_employee.Name = "pb_employee";
            this.pb_employee.Size = new System.Drawing.Size(396, 343);
            this.pb_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_employee.TabIndex = 0;
            this.pb_employee.TabStop = false;
            // 
            // pl_right
            // 
            this.pl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_right.Controls.Add(this.flowLayoutPanel1);
            this.pl_right.Controls.Add(this.btn_login);
            this.pl_right.Controls.Add(this.tb_password);
            this.pl_right.Controls.Add(this.tb_email);
            this.pl_right.Controls.Add(this.lb_password);
            this.pl_right.Controls.Add(this.lb_email);
            this.pl_right.Controls.Add(this.pb_password);
            this.pl_right.Controls.Add(this.pb_email);
            this.pl_right.Controls.Add(this.lb_right);
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_right.Location = new System.Drawing.Point(396, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(618, 628);
            this.pl_right.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(260, 366);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(149, 53);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Location = new System.Drawing.Point(260, 303);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(313, 40);
            this.tb_password.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_email.Location = new System.Drawing.Point(260, 228);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(313, 40);
            this.tb_email.TabIndex = 5;
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(154, 303);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(100, 40);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            this.lb_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_email
            // 
            this.lb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(154, 228);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(100, 40);
            this.lb_email.TabIndex = 3;
            this.lb_email.Text = "Email";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_password
            // 
            this.pb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_password.Image = ((System.Drawing.Image)(resources.GetObject("pb_password.Image")));
            this.pb_password.Location = new System.Drawing.Point(108, 303);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(40, 40);
            this.pb_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_password.TabIndex = 2;
            this.pb_password.TabStop = false;
            // 
            // pb_email
            // 
            this.pb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_email.Image = ((System.Drawing.Image)(resources.GetObject("pb_email.Image")));
            this.pb_email.Location = new System.Drawing.Point(108, 228);
            this.pb_email.Name = "pb_email";
            this.pb_email.Size = new System.Drawing.Size(40, 40);
            this.pb_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_email.TabIndex = 1;
            this.pb_email.TabStop = false;
            // 
            // lb_right
            // 
            this.lb_right.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_right.Location = new System.Drawing.Point(0, 0);
            this.lb_right.Name = "lb_right";
            this.lb_right.Size = new System.Drawing.Size(618, 77);
            this.lb_right.TabIndex = 0;
            this.lb_right.Text = "Employee Manager System";
            this.lb_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 650);
            this.Name = "UserDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS";
            this.pl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).EndInit();
            this.pl_right.ResumeLayout(false);
            this.pl_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.PictureBox pb_employee;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.PictureBox pb_email;
        private System.Windows.Forms.Label lb_right;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_cancel;
    }
}