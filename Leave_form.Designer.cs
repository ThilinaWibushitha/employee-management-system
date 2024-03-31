namespace Employee_Management_System
{
    partial class Leave_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave_form));
            this.pl_left = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lb_startDate = new System.Windows.Forms.Label();
            this.lb_endDate = new System.Windows.Forms.Label();
            this.lb_reason = new System.Windows.Forms.Label();
            this.lb_leaveType = new System.Windows.Forms.Label();
            this.lb_managerId = new System.Windows.Forms.Label();
            this.lb_employeeId = new System.Windows.Forms.Label();
            this.lb_requestId = new System.Windows.Forms.Label();
            this.tb_requestId = new System.Windows.Forms.TextBox();
            this.pl_right = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lb_requestLeave = new System.Windows.Forms.Label();
            this.tb_reason = new System.Windows.Forms.TextBox();
            this.tb_startDate = new System.Windows.Forms.TextBox();
            this.tb_endDate = new System.Windows.Forms.TextBox();
            this.cb_leaveType = new System.Windows.Forms.ComboBox();
            this.tb_managerId = new System.Windows.Forms.TextBox();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.pl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.pl_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_left.Controls.Add(this.pb_icon);
            this.pl_left.Controls.Add(this.lb_startDate);
            this.pl_left.Controls.Add(this.lb_endDate);
            this.pl_left.Controls.Add(this.lb_reason);
            this.pl_left.Controls.Add(this.lb_leaveType);
            this.pl_left.Controls.Add(this.lb_managerId);
            this.pl_left.Controls.Add(this.lb_employeeId);
            this.pl_left.Controls.Add(this.lb_requestId);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(359, 666);
            this.pl_left.TabIndex = 0;
            // 
            // pb_icon
            // 
            this.pb_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_icon.Image = global::Employee_Management_System.Properties.Resources.leave_5_512;
            this.pb_icon.Location = new System.Drawing.Point(0, 0);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(359, 90);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 7;
            this.pb_icon.TabStop = false;
            // 
            // lb_startDate
            // 
            this.lb_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startDate.Location = new System.Drawing.Point(47, 451);
            this.lb_startDate.Name = "lb_startDate";
            this.lb_startDate.Size = new System.Drawing.Size(138, 50);
            this.lb_startDate.TabIndex = 5;
            this.lb_startDate.Text = "Start Date\r\n(YYYY/MM/DD)\r\n";
            this.lb_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_endDate
            // 
            this.lb_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endDate.Location = new System.Drawing.Point(47, 517);
            this.lb_endDate.Name = "lb_endDate";
            this.lb_endDate.Size = new System.Drawing.Size(150, 50);
            this.lb_endDate.TabIndex = 6;
            this.lb_endDate.Text = "End Date\r\n(YYYY/MM/DD)\r\n";
            this.lb_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_reason
            // 
            this.lb_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reason.Location = new System.Drawing.Point(47, 385);
            this.lb_reason.Name = "lb_reason";
            this.lb_reason.Size = new System.Drawing.Size(140, 45);
            this.lb_reason.TabIndex = 4;
            this.lb_reason.Text = "Reason";
            this.lb_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_leaveType
            // 
            this.lb_leaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_leaveType.Location = new System.Drawing.Point(47, 336);
            this.lb_leaveType.Name = "lb_leaveType";
            this.lb_leaveType.Size = new System.Drawing.Size(140, 30);
            this.lb_leaveType.TabIndex = 3;
            this.lb_leaveType.Text = "Leave Type";
            this.lb_leaveType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_managerId
            // 
            this.lb_managerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_managerId.Location = new System.Drawing.Point(47, 276);
            this.lb_managerId.Name = "lb_managerId";
            this.lb_managerId.Size = new System.Drawing.Size(140, 45);
            this.lb_managerId.TabIndex = 2;
            this.lb_managerId.Text = "Manager ID";
            this.lb_managerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_employeeId
            // 
            this.lb_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeId.Location = new System.Drawing.Point(47, 211);
            this.lb_employeeId.Name = "lb_employeeId";
            this.lb_employeeId.Size = new System.Drawing.Size(140, 45);
            this.lb_employeeId.TabIndex = 1;
            this.lb_employeeId.Text = "Employee ID";
            this.lb_employeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_requestId
            // 
            this.lb_requestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_requestId.Location = new System.Drawing.Point(47, 149);
            this.lb_requestId.Name = "lb_requestId";
            this.lb_requestId.Size = new System.Drawing.Size(140, 45);
            this.lb_requestId.TabIndex = 0;
            this.lb_requestId.Text = "Request ID";
            this.lb_requestId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_requestId
            // 
            this.tb_requestId.Location = new System.Drawing.Point(58, 149);
            this.tb_requestId.Multiline = true;
            this.tb_requestId.Name = "tb_requestId";
            this.tb_requestId.Size = new System.Drawing.Size(355, 45);
            this.tb_requestId.TabIndex = 1;
            // 
            // pl_right
            // 
            this.pl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.pl_right.Controls.Add(this.btn_back);
            this.pl_right.Controls.Add(this.btn_submit);
            this.pl_right.Controls.Add(this.lb_requestLeave);
            this.pl_right.Controls.Add(this.tb_reason);
            this.pl_right.Controls.Add(this.tb_startDate);
            this.pl_right.Controls.Add(this.tb_endDate);
            this.pl_right.Controls.Add(this.cb_leaveType);
            this.pl_right.Controls.Add(this.tb_managerId);
            this.pl_right.Controls.Add(this.tb_requestId);
            this.pl_right.Controls.Add(this.tb_employeeId);
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_right.Location = new System.Drawing.Point(359, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(699, 666);
            this.pl_right.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(487, 517);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(137, 50);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Location = new System.Drawing.Point(487, 451);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(137, 50);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lb_requestLeave
            // 
            this.lb_requestLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_requestLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_requestLeave.Location = new System.Drawing.Point(0, 0);
            this.lb_requestLeave.Name = "lb_requestLeave";
            this.lb_requestLeave.Size = new System.Drawing.Size(699, 90);
            this.lb_requestLeave.TabIndex = 8;
            this.lb_requestLeave.Text = "Request Leave";
            this.lb_requestLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_reason
            // 
            this.tb_reason.Location = new System.Drawing.Point(58, 385);
            this.tb_reason.Multiline = true;
            this.tb_reason.Name = "tb_reason";
            this.tb_reason.Size = new System.Drawing.Size(355, 45);
            this.tb_reason.TabIndex = 5;
            // 
            // tb_startDate
            // 
            this.tb_startDate.Location = new System.Drawing.Point(58, 451);
            this.tb_startDate.Multiline = true;
            this.tb_startDate.Name = "tb_startDate";
            this.tb_startDate.Size = new System.Drawing.Size(355, 50);
            this.tb_startDate.TabIndex = 6;
            // 
            // tb_endDate
            // 
            this.tb_endDate.Location = new System.Drawing.Point(58, 517);
            this.tb_endDate.Multiline = true;
            this.tb_endDate.Name = "tb_endDate";
            this.tb_endDate.Size = new System.Drawing.Size(355, 50);
            this.tb_endDate.TabIndex = 7;
            // 
            // cb_leaveType
            // 
            this.cb_leaveType.FormattingEnabled = true;
            this.cb_leaveType.Items.AddRange(new object[] {
            "Sick Leave",
            "Unpaid Leave",
            "Family and Medical Leave"});
            this.cb_leaveType.Location = new System.Drawing.Point(58, 336);
            this.cb_leaveType.Name = "cb_leaveType";
            this.cb_leaveType.Size = new System.Drawing.Size(355, 28);
            this.cb_leaveType.TabIndex = 4;
            // 
            // tb_managerId
            // 
            this.tb_managerId.Location = new System.Drawing.Point(58, 276);
            this.tb_managerId.Multiline = true;
            this.tb_managerId.Name = "tb_managerId";
            this.tb_managerId.Size = new System.Drawing.Size(355, 45);
            this.tb_managerId.TabIndex = 3;
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(58, 211);
            this.tb_employeeId.Multiline = true;
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(355, 45);
            this.tb_employeeId.TabIndex = 2;
            // 
            // Leave_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 666);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leave_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Request Leave";
            this.pl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.pl_right.ResumeLayout(false);
            this.pl_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Label lb_employeeId;
        private System.Windows.Forms.Label lb_requestId;
        private System.Windows.Forms.Label lb_managerId;
        private System.Windows.Forms.Label lb_reason;
        private System.Windows.Forms.Label lb_leaveType;
        private System.Windows.Forms.Label lb_startDate;
        private System.Windows.Forms.Label lb_endDate;
        private System.Windows.Forms.TextBox tb_requestId;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.TextBox tb_reason;
        private System.Windows.Forms.TextBox tb_startDate;
        private System.Windows.Forms.TextBox tb_endDate;
        private System.Windows.Forms.ComboBox cb_leaveType;
        private System.Windows.Forms.TextBox tb_managerId;
        private System.Windows.Forms.Label lb_requestLeave;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back;
    }
}