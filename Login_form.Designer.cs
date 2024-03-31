namespace Employee_Management_System
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.pl_login = new System.Windows.Forms.Panel();
            this.pl_login_details = new System.Windows.Forms.Panel();
            this.lb_userType = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.llb_Forgotten = new System.Windows.Forms.LinkLabel();
            this.tb_password_log = new System.Windows.Forms.TextBox();
            this.tb_email_log = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.pb_userType = new System.Windows.Forms.PictureBox();
            this.pb_password = new System.Windows.Forms.PictureBox();
            this.pb_email = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.pl_login.SuspendLayout();
            this.pl_login_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_login
            // 
            this.pl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_login.Controls.Add(this.pl_login_details);
            this.pl_login.Controls.Add(this.pb_login);
            this.pl_login.Controls.Add(this.lb_login);
            this.pl_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_login.Location = new System.Drawing.Point(0, 0);
            this.pl_login.Name = "pl_login";
            this.pl_login.Size = new System.Drawing.Size(1013, 592);
            this.pl_login.TabIndex = 0;
            // 
            // pl_login_details
            // 
            this.pl_login_details.Controls.Add(this.pb_userType);
            this.pl_login_details.Controls.Add(this.lb_userType);
            this.pl_login_details.Controls.Add(this.cb_select);
            this.pl_login_details.Controls.Add(this.btn_back);
            this.pl_login_details.Controls.Add(this.btn_login);
            this.pl_login_details.Controls.Add(this.llb_Forgotten);
            this.pl_login_details.Controls.Add(this.tb_password_log);
            this.pl_login_details.Controls.Add(this.tb_email_log);
            this.pl_login_details.Controls.Add(this.lb_password);
            this.pl_login_details.Controls.Add(this.lb_email);
            this.pl_login_details.Controls.Add(this.pb_password);
            this.pl_login_details.Controls.Add(this.pb_email);
            this.pl_login_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_login_details.Location = new System.Drawing.Point(0, 137);
            this.pl_login_details.Name = "pl_login_details";
            this.pl_login_details.Size = new System.Drawing.Size(1013, 455);
            this.pl_login_details.TabIndex = 2;
            // 
            // lb_userType
            // 
            this.lb_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userType.Location = new System.Drawing.Point(347, 76);
            this.lb_userType.Name = "lb_userType";
            this.lb_userType.Size = new System.Drawing.Size(96, 40);
            this.lb_userType.TabIndex = 10;
            this.lb_userType.Text = "User Type";
            this.lb_userType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_select
            // 
            this.cb_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.cb_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_select.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Items.AddRange(new object[] {
            "Manager",
            "Admin",
            "Employee"});
            this.cb_select.Location = new System.Drawing.Point(453, 83);
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(149, 30);
            this.cb_select.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(616, 312);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 40);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(453, 312);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(113, 40);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llb_Forgotten
            // 
            this.llb_Forgotten.AutoSize = true;
            this.llb_Forgotten.Location = new System.Drawing.Point(453, 261);
            this.llb_Forgotten.Name = "llb_Forgotten";
            this.llb_Forgotten.Size = new System.Drawing.Size(161, 20);
            this.llb_Forgotten.TabIndex = 6;
            this.llb_Forgotten.TabStop = true;
            this.llb_Forgotten.Text = "Forgotten Password?";
            this.llb_Forgotten.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Forgotten_LinkClicked);
            // 
            // tb_password_log
            // 
            this.tb_password_log.Location = new System.Drawing.Point(453, 206);
            this.tb_password_log.Multiline = true;
            this.tb_password_log.Name = "tb_password_log";
            this.tb_password_log.PasswordChar = '*';
            this.tb_password_log.Size = new System.Drawing.Size(276, 40);
            this.tb_password_log.TabIndex = 5;
            // 
            // tb_email_log
            // 
            this.tb_email_log.Location = new System.Drawing.Point(453, 133);
            this.tb_email_log.Multiline = true;
            this.tb_email_log.Name = "tb_email_log";
            this.tb_email_log.Size = new System.Drawing.Size(276, 40);
            this.tb_email_log.TabIndex = 4;
            // 
            // lb_password
            // 
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(347, 206);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(100, 40);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password";
            this.lb_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_email
            // 
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(347, 133);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(100, 40);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_login
            // 
            this.lb_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(0, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(1013, 87);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_userType
            // 
            this.pb_userType.Image = global::Employee_Management_System.Properties.Resources.vecteezy_contact_person_red_icon_8506404;
            this.pb_userType.Location = new System.Drawing.Point(300, 76);
            this.pb_userType.Name = "pb_userType";
            this.pb_userType.Size = new System.Drawing.Size(40, 40);
            this.pb_userType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_userType.TabIndex = 11;
            this.pb_userType.TabStop = false;
            // 
            // pb_password
            // 
            this.pb_password.Image = global::Employee_Management_System.Properties.Resources.padlock_2_512;
            this.pb_password.Location = new System.Drawing.Point(300, 206);
            this.pb_password.Name = "pb_password";
            this.pb_password.Size = new System.Drawing.Size(40, 40);
            this.pb_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_password.TabIndex = 1;
            this.pb_password.TabStop = false;
            // 
            // pb_email
            // 
            this.pb_email.Image = global::Employee_Management_System.Properties.Resources.pngwing_com;
            this.pb_email.Location = new System.Drawing.Point(300, 133);
            this.pb_email.Name = "pb_email";
            this.pb_email.Size = new System.Drawing.Size(40, 40);
            this.pb_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_email.TabIndex = 0;
            this.pb_email.TabStop = false;
            // 
            // pb_login
            // 
            this.pb_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_login.Image = ((System.Drawing.Image)(resources.GetObject("pb_login.Image")));
            this.pb_login.Location = new System.Drawing.Point(0, 87);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(1013, 50);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_login.TabIndex = 1;
            this.pb_login.TabStop = false;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.pl_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Login";
            this.pl_login.ResumeLayout(false);
            this.pl_login_details.ResumeLayout(false);
            this.pl_login_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Panel pl_login_details;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.PictureBox pb_password;
        private System.Windows.Forms.PictureBox pb_email;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.LinkLabel llb_Forgotten;
        private System.Windows.Forms.TextBox tb_password_log;
        private System.Windows.Forms.TextBox tb_email_log;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label lb_userType;
        private System.Windows.Forms.PictureBox pb_userType;
    }
}