namespace Employee_Management_System
{
    partial class ResetPassword_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword_form));
            this.pn_fill = new System.Windows.Forms.Panel();
            this.lb_old_password = new System.Windows.Forms.Label();
            this.lb_reset_text = new System.Windows.Forms.Label();
            this.tb_oldPassword = new System.Windows.Forms.TextBox();
            this.lb_new_password = new System.Windows.Forms.Label();
            this.tb_newPassword = new System.Windows.Forms.TextBox();
            this.btn_conform = new System.Windows.Forms.Button();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.pn_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_fill
            // 
            this.pn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pn_fill.Controls.Add(this.btn_back);
            this.pn_fill.Controls.Add(this.tb_email);
            this.pn_fill.Controls.Add(this.lb_email);
            this.pn_fill.Controls.Add(this.btn_conform);
            this.pn_fill.Controls.Add(this.tb_newPassword);
            this.pn_fill.Controls.Add(this.lb_new_password);
            this.pn_fill.Controls.Add(this.tb_oldPassword);
            this.pn_fill.Controls.Add(this.lb_reset_text);
            this.pn_fill.Controls.Add(this.lb_old_password);
            this.pn_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_fill.Location = new System.Drawing.Point(0, 0);
            this.pn_fill.Name = "pn_fill";
            this.pn_fill.Size = new System.Drawing.Size(595, 363);
            this.pn_fill.TabIndex = 0;
            // 
            // lb_old_password
            // 
            this.lb_old_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_old_password.Location = new System.Drawing.Point(90, 160);
            this.lb_old_password.Name = "lb_old_password";
            this.lb_old_password.Size = new System.Drawing.Size(126, 40);
            this.lb_old_password.TabIndex = 0;
            this.lb_old_password.Text = "Old Password";
            this.lb_old_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_reset_text
            // 
            this.lb_reset_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_reset_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reset_text.Location = new System.Drawing.Point(0, 0);
            this.lb_reset_text.Name = "lb_reset_text";
            this.lb_reset_text.Size = new System.Drawing.Size(595, 51);
            this.lb_reset_text.TabIndex = 1;
            this.lb_reset_text.Text = "Forget Password";
            this.lb_reset_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_oldPassword
            // 
            this.tb_oldPassword.Location = new System.Drawing.Point(262, 160);
            this.tb_oldPassword.Multiline = true;
            this.tb_oldPassword.Name = "tb_oldPassword";
            this.tb_oldPassword.Size = new System.Drawing.Size(277, 40);
            this.tb_oldPassword.TabIndex = 2;
            // 
            // lb_new_password
            // 
            this.lb_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_new_password.Location = new System.Drawing.Point(90, 218);
            this.lb_new_password.Name = "lb_new_password";
            this.lb_new_password.Size = new System.Drawing.Size(152, 40);
            this.lb_new_password.TabIndex = 3;
            this.lb_new_password.Text = "New Password";
            this.lb_new_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.Location = new System.Drawing.Point(262, 218);
            this.tb_newPassword.Multiline = true;
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.Size = new System.Drawing.Size(277, 40);
            this.tb_newPassword.TabIndex = 4;
            // 
            // btn_conform
            // 
            this.btn_conform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_conform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_conform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conform.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_conform.Location = new System.Drawing.Point(262, 281);
            this.btn_conform.Name = "btn_conform";
            this.btn_conform.Size = new System.Drawing.Size(117, 42);
            this.btn_conform.TabIndex = 5;
            this.btn_conform.Text = "Conform";
            this.btn_conform.UseVisualStyleBackColor = false;
            this.btn_conform.Click += new System.EventHandler(this.btn_conform_Click);
            // 
            // lb_email
            // 
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(90, 100);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(126, 40);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email";
            this.lb_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(262, 100);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(277, 40);
            this.tb_email.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(422, 281);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 42);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ResetPassword_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 363);
            this.Controls.Add(this.pn_fill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Reset Password";
            this.pn_fill.ResumeLayout(false);
            this.pn_fill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_fill;
        private System.Windows.Forms.Label lb_reset_text;
        private System.Windows.Forms.Label lb_old_password;
        private System.Windows.Forms.Button btn_conform;
        private System.Windows.Forms.TextBox tb_newPassword;
        private System.Windows.Forms.Label lb_new_password;
        private System.Windows.Forms.TextBox tb_oldPassword;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Button btn_back;
    }
}