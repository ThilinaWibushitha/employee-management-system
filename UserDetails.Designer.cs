namespace Employee_Management_System
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.pl_left = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pl_details = new System.Windows.Forms.Panel();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_details = new System.Windows.Forms.Label();
            this.lb_userId = new System.Windows.Forms.Label();
            this.pl_left.SuspendLayout();
            this.pl_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_left.Controls.Add(this.btn_back);
            this.pl_left.Controls.Add(this.pl_details);
            this.pl_left.Controls.Add(this.btn_ok);
            this.pl_left.Controls.Add(this.tb_id);
            this.pl_left.Controls.Add(this.lb_details);
            this.pl_left.Controls.Add(this.lb_userId);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(1014, 628);
            this.pl_left.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(618, 83);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 44);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pl_details
            // 
            this.pl_details.Controls.Add(this.dgv_details);
            this.pl_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_details.Location = new System.Drawing.Point(0, 333);
            this.pl_details.Name = "pl_details";
            this.pl_details.Size = new System.Drawing.Size(1014, 295);
            this.pl_details.TabIndex = 4;
            // 
            // dgv_details
            // 
            this.dgv_details.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(0, 0);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 62;
            this.dgv_details.RowTemplate.Height = 28;
            this.dgv_details.Size = new System.Drawing.Size(1014, 295);
            this.dgv_details.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ok.Location = new System.Drawing.Point(515, 83);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(73, 44);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(157, 87);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(335, 40);
            this.tb_id.TabIndex = 2;
            // 
            // lb_details
            // 
            this.lb_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_details.Location = new System.Drawing.Point(0, 0);
            this.lb_details.Name = "lb_details";
            this.lb_details.Size = new System.Drawing.Size(1014, 61);
            this.lb_details.TabIndex = 1;
            this.lb_details.Text = "Your Details";
            this.lb_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_userId
            // 
            this.lb_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userId.Location = new System.Drawing.Point(12, 83);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(139, 44);
            this.lb_userId.TabIndex = 0;
            this.lb_userId.Text = " User ID";
            this.lb_userId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 650);
            this.Name = "UserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS User Details";
            this.pl_left.ResumeLayout(false);
            this.pl_left.PerformLayout();
            this.pl_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Label lb_userId;
        private System.Windows.Forms.Label lb_details;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel pl_details;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Button btn_back;
    }
}