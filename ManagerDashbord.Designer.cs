namespace Employee_Management_System
{
    partial class ManagerDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashbord));
            this.left_panel = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_createSalary = new System.Windows.Forms.Button();
            this.btn_rejectLeave = new System.Windows.Forms.Button();
            this.btn_approveLeave = new System.Windows.Forms.Button();
            this.pb_employee = new System.Windows.Forms.PictureBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_requestId = new System.Windows.Forms.Label();
            this.tb_requestId = new System.Windows.Forms.TextBox();
            this.dgv_leaveDetails = new System.Windows.Forms.DataGridView();
            this.btn_check = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaveDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.left_panel.Controls.Add(this.btn_cancel);
            this.left_panel.Controls.Add(this.btn_back);
            this.left_panel.Controls.Add(this.btn_createSalary);
            this.left_panel.Controls.Add(this.btn_rejectLeave);
            this.left_panel.Controls.Add(this.btn_approveLeave);
            this.left_panel.Controls.Add(this.pb_employee);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(269, 619);
            this.left_panel.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AllowDrop = true;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(0, 535);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(269, 84);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(0, 468);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(269, 67);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_createSalary
            // 
            this.btn_createSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_createSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_createSalary.Location = new System.Drawing.Point(0, 401);
            this.btn_createSalary.Name = "btn_createSalary";
            this.btn_createSalary.Size = new System.Drawing.Size(269, 67);
            this.btn_createSalary.TabIndex = 4;
            this.btn_createSalary.Text = "Create Salary";
            this.btn_createSalary.UseVisualStyleBackColor = false;
            this.btn_createSalary.Click += new System.EventHandler(this.btn_createSalary_Click);
            // 
            // btn_rejectLeave
            // 
            this.btn_rejectLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_rejectLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rejectLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rejectLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rejectLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rejectLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rejectLeave.Location = new System.Drawing.Point(0, 334);
            this.btn_rejectLeave.Name = "btn_rejectLeave";
            this.btn_rejectLeave.Size = new System.Drawing.Size(269, 67);
            this.btn_rejectLeave.TabIndex = 2;
            this.btn_rejectLeave.Text = "Reject Leave";
            this.btn_rejectLeave.UseVisualStyleBackColor = false;
            this.btn_rejectLeave.Click += new System.EventHandler(this.btn_rejectLeave_Click);
            // 
            // btn_approveLeave
            // 
            this.btn_approveLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_approveLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approveLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_approveLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_approveLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approveLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_approveLeave.Location = new System.Drawing.Point(0, 267);
            this.btn_approveLeave.Name = "btn_approveLeave";
            this.btn_approveLeave.Size = new System.Drawing.Size(269, 67);
            this.btn_approveLeave.TabIndex = 1;
            this.btn_approveLeave.Text = "Approve Leave";
            this.btn_approveLeave.UseVisualStyleBackColor = false;
            this.btn_approveLeave.Click += new System.EventHandler(this.btn_approveLeave_Click);
            // 
            // pb_employee
            // 
            this.pb_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_employee.Image = global::Employee_Management_System.Properties.Resources.employee1;
            this.pb_employee.Location = new System.Drawing.Point(0, 0);
            this.pb_employee.Name = "pb_employee";
            this.pb_employee.Size = new System.Drawing.Size(269, 267);
            this.pb_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_employee.TabIndex = 8;
            this.pb_employee.TabStop = false;
            // 
            // lb_text
            // 
            this.lb_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.lb_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(269, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(815, 69);
            this.lb_text.TabIndex = 1;
            this.lb_text.Text = "Manager Dashbord";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_requestId
            // 
            this.lb_requestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_requestId.Location = new System.Drawing.Point(374, 142);
            this.lb_requestId.Name = "lb_requestId";
            this.lb_requestId.Size = new System.Drawing.Size(140, 45);
            this.lb_requestId.TabIndex = 2;
            this.lb_requestId.Text = "Request ID";
            this.lb_requestId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_requestId
            // 
            this.tb_requestId.Location = new System.Drawing.Point(529, 142);
            this.tb_requestId.Multiline = true;
            this.tb_requestId.Name = "tb_requestId";
            this.tb_requestId.Size = new System.Drawing.Size(230, 45);
            this.tb_requestId.TabIndex = 3;
            // 
            // dgv_leaveDetails
            // 
            this.dgv_leaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leaveDetails.Location = new System.Drawing.Point(269, 265);
            this.dgv_leaveDetails.Name = "dgv_leaveDetails";
            this.dgv_leaveDetails.RowHeadersWidth = 62;
            this.dgv_leaveDetails.RowTemplate.Height = 28;
            this.dgv_leaveDetails.Size = new System.Drawing.Size(815, 354);
            this.dgv_leaveDetails.TabIndex = 4;
            this.dgv_leaveDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_check.Location = new System.Drawing.Point(826, 142);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(193, 45);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Check Request";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // ManagerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1077, 628);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dgv_leaveDetails);
            this.Controls.Add(this.tb_requestId);
            this.Controls.Add(this.lb_requestId);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.left_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Manager Dashbord";
            this.left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaveDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Button btn_approveLeave;
        private System.Windows.Forms.Button btn_createSalary;
        private System.Windows.Forms.Button btn_rejectLeave;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pb_employee;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_requestId;
        private System.Windows.Forms.TextBox tb_requestId;
        private System.Windows.Forms.DataGridView dgv_leaveDetails;
        private System.Windows.Forms.Button btn_check;
    }
}