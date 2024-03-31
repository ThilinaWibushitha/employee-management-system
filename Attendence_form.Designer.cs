namespace Employee_Management_System
{
    partial class Attendence_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence_form));
            this.pl_full = new System.Windows.Forms.Panel();
            this.lb_attendenceId = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_timeIn = new System.Windows.Forms.Label();
            this.lb_timeOut = new System.Windows.Forms.Label();
            this.lb_employeeId = new System.Windows.Forms.Label();
            this.tb_attendenceId = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_timeIn = new System.Windows.Forms.TextBox();
            this.tb_timeOut = new System.Windows.Forms.TextBox();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pl_full.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_full
            // 
            this.pl_full.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_full.Controls.Add(this.btn_back);
            this.pl_full.Controls.Add(this.btn_enter);
            this.pl_full.Controls.Add(this.tb_employeeId);
            this.pl_full.Controls.Add(this.tb_timeOut);
            this.pl_full.Controls.Add(this.tb_timeIn);
            this.pl_full.Controls.Add(this.tb_status);
            this.pl_full.Controls.Add(this.tb_attendenceId);
            this.pl_full.Controls.Add(this.lb_employeeId);
            this.pl_full.Controls.Add(this.lb_timeOut);
            this.pl_full.Controls.Add(this.lb_timeIn);
            this.pl_full.Controls.Add(this.lb_status);
            this.pl_full.Controls.Add(this.lb_attendenceId);
            this.pl_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_full.Location = new System.Drawing.Point(0, 0);
            this.pl_full.Name = "pl_full";
            this.pl_full.Size = new System.Drawing.Size(1052, 659);
            this.pl_full.TabIndex = 0;
            // 
            // lb_attendenceId
            // 
            this.lb_attendenceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_attendenceId.Location = new System.Drawing.Point(270, 117);
            this.lb_attendenceId.Name = "lb_attendenceId";
            this.lb_attendenceId.Size = new System.Drawing.Size(124, 45);
            this.lb_attendenceId.TabIndex = 0;
            this.lb_attendenceId.Text = "Attendence ID";
            this.lb_attendenceId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(270, 189);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(124, 45);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "Status";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_timeIn
            // 
            this.lb_timeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeIn.Location = new System.Drawing.Point(270, 259);
            this.lb_timeIn.Name = "lb_timeIn";
            this.lb_timeIn.Size = new System.Drawing.Size(124, 45);
            this.lb_timeIn.TabIndex = 2;
            this.lb_timeIn.Text = "Time In";
            this.lb_timeIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_timeOut
            // 
            this.lb_timeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeOut.Location = new System.Drawing.Point(270, 330);
            this.lb_timeOut.Name = "lb_timeOut";
            this.lb_timeOut.Size = new System.Drawing.Size(124, 45);
            this.lb_timeOut.TabIndex = 3;
            this.lb_timeOut.Text = "Time Out";
            this.lb_timeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_employeeId
            // 
            this.lb_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeId.Location = new System.Drawing.Point(270, 395);
            this.lb_employeeId.Name = "lb_employeeId";
            this.lb_employeeId.Size = new System.Drawing.Size(124, 45);
            this.lb_employeeId.TabIndex = 4;
            this.lb_employeeId.Text = "Employee ID";
            this.lb_employeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_attendenceId
            // 
            this.tb_attendenceId.Location = new System.Drawing.Point(469, 117);
            this.tb_attendenceId.Multiline = true;
            this.tb_attendenceId.Name = "tb_attendenceId";
            this.tb_attendenceId.Size = new System.Drawing.Size(469, 45);
            this.tb_attendenceId.TabIndex = 5;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(469, 189);
            this.tb_status.Multiline = true;
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(469, 45);
            this.tb_status.TabIndex = 6;
            // 
            // tb_timeIn
            // 
            this.tb_timeIn.Location = new System.Drawing.Point(469, 259);
            this.tb_timeIn.Multiline = true;
            this.tb_timeIn.Name = "tb_timeIn";
            this.tb_timeIn.Size = new System.Drawing.Size(469, 45);
            this.tb_timeIn.TabIndex = 7;
            // 
            // tb_timeOut
            // 
            this.tb_timeOut.Location = new System.Drawing.Point(469, 330);
            this.tb_timeOut.Multiline = true;
            this.tb_timeOut.Name = "tb_timeOut";
            this.tb_timeOut.Size = new System.Drawing.Size(469, 45);
            this.tb_timeOut.TabIndex = 8;
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(469, 395);
            this.tb_employeeId.Multiline = true;
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(469, 45);
            this.tb_employeeId.TabIndex = 9;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_enter.Location = new System.Drawing.Point(469, 487);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(148, 51);
            this.btn_enter.TabIndex = 10;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(706, 487);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(148, 51);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Attendence_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 659);
            this.Controls.Add(this.pl_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendence_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Attendence";
            this.pl_full.ResumeLayout(false);
            this.pl_full.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_full;
        private System.Windows.Forms.TextBox tb_attendenceId;
        private System.Windows.Forms.Label lb_employeeId;
        private System.Windows.Forms.Label lb_timeOut;
        private System.Windows.Forms.Label lb_timeIn;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_attendenceId;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.TextBox tb_timeOut;
        private System.Windows.Forms.TextBox tb_timeIn;
        private System.Windows.Forms.Button btn_back;
    }
}