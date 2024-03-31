namespace Employee_Management_System
{
    partial class payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payroll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_managerId = new System.Windows.Forms.TextBox();
            this.tb_basicSalary = new System.Windows.Forms.TextBox();
            this.tb_totalSalary = new System.Windows.Forms.TextBox();
            this.tb_paymentDate = new System.Windows.Forms.TextBox();
            this.tb_employeeId = new System.Windows.Forms.TextBox();
            this.tb_payId = new System.Windows.Forms.TextBox();
            this.lb_managerId = new System.Windows.Forms.Label();
            this.lb_paymentDate = new System.Windows.Forms.Label();
            this.lb_employeeId = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_basic = new System.Windows.Forms.Label();
            this.lb_payId = new System.Windows.Forms.Label();
            this.lb_header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.lb_header);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_enter);
            this.panel1.Controls.Add(this.tb_managerId);
            this.panel1.Controls.Add(this.tb_basicSalary);
            this.panel1.Controls.Add(this.tb_totalSalary);
            this.panel1.Controls.Add(this.tb_paymentDate);
            this.panel1.Controls.Add(this.tb_employeeId);
            this.panel1.Controls.Add(this.tb_payId);
            this.panel1.Controls.Add(this.lb_managerId);
            this.panel1.Controls.Add(this.lb_paymentDate);
            this.panel1.Controls.Add(this.lb_employeeId);
            this.panel1.Controls.Add(this.lb_total);
            this.panel1.Controls.Add(this.lb_basic);
            this.panel1.Controls.Add(this.lb_payId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 628);
            this.panel1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(751, 476);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(134, 45);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(150)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_enter.Location = new System.Drawing.Point(751, 401);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(134, 45);
            this.btn_enter.TabIndex = 12;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_managerId
            // 
            this.tb_managerId.Location = new System.Drawing.Point(361, 476);
            this.tb_managerId.Multiline = true;
            this.tb_managerId.Name = "tb_managerId";
            this.tb_managerId.Size = new System.Drawing.Size(342, 45);
            this.tb_managerId.TabIndex = 11;
            // 
            // tb_basicSalary
            // 
            this.tb_basicSalary.Location = new System.Drawing.Point(361, 190);
            this.tb_basicSalary.Multiline = true;
            this.tb_basicSalary.Name = "tb_basicSalary";
            this.tb_basicSalary.Size = new System.Drawing.Size(342, 45);
            this.tb_basicSalary.TabIndex = 7;
            // 
            // tb_totalSalary
            // 
            this.tb_totalSalary.Location = new System.Drawing.Point(361, 260);
            this.tb_totalSalary.Multiline = true;
            this.tb_totalSalary.Name = "tb_totalSalary";
            this.tb_totalSalary.Size = new System.Drawing.Size(342, 45);
            this.tb_totalSalary.TabIndex = 8;
            // 
            // tb_paymentDate
            // 
            this.tb_paymentDate.Location = new System.Drawing.Point(361, 330);
            this.tb_paymentDate.Multiline = true;
            this.tb_paymentDate.Name = "tb_paymentDate";
            this.tb_paymentDate.Size = new System.Drawing.Size(342, 45);
            this.tb_paymentDate.TabIndex = 9;
            // 
            // tb_employeeId
            // 
            this.tb_employeeId.Location = new System.Drawing.Point(361, 401);
            this.tb_employeeId.Multiline = true;
            this.tb_employeeId.Name = "tb_employeeId";
            this.tb_employeeId.Size = new System.Drawing.Size(342, 45);
            this.tb_employeeId.TabIndex = 10;
            // 
            // tb_payId
            // 
            this.tb_payId.Location = new System.Drawing.Point(361, 118);
            this.tb_payId.Multiline = true;
            this.tb_payId.Name = "tb_payId";
            this.tb_payId.Size = new System.Drawing.Size(342, 45);
            this.tb_payId.TabIndex = 6;
            // 
            // lb_managerId
            // 
            this.lb_managerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_managerId.Location = new System.Drawing.Point(205, 476);
            this.lb_managerId.Name = "lb_managerId";
            this.lb_managerId.Size = new System.Drawing.Size(131, 45);
            this.lb_managerId.TabIndex = 5;
            this.lb_managerId.Text = "Manager ID";
            this.lb_managerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_paymentDate
            // 
            this.lb_paymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_paymentDate.Location = new System.Drawing.Point(205, 330);
            this.lb_paymentDate.Name = "lb_paymentDate";
            this.lb_paymentDate.Size = new System.Drawing.Size(131, 45);
            this.lb_paymentDate.TabIndex = 3;
            this.lb_paymentDate.Text = "Payment Date";
            this.lb_paymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_employeeId
            // 
            this.lb_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeId.Location = new System.Drawing.Point(205, 401);
            this.lb_employeeId.Name = "lb_employeeId";
            this.lb_employeeId.Size = new System.Drawing.Size(131, 45);
            this.lb_employeeId.TabIndex = 4;
            this.lb_employeeId.Text = "Employee ID";
            this.lb_employeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total
            // 
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(205, 260);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(131, 45);
            this.lb_total.TabIndex = 2;
            this.lb_total.Text = "Total Salary";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_basic
            // 
            this.lb_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_basic.Location = new System.Drawing.Point(205, 190);
            this.lb_basic.Name = "lb_basic";
            this.lb_basic.Size = new System.Drawing.Size(131, 45);
            this.lb_basic.TabIndex = 1;
            this.lb_basic.Text = "Basic Salary";
            this.lb_basic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_payId
            // 
            this.lb_payId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_payId.Location = new System.Drawing.Point(205, 118);
            this.lb_payId.Name = "lb_payId";
            this.lb_payId.Size = new System.Drawing.Size(131, 45);
            this.lb_payId.TabIndex = 0;
            this.lb_payId.Text = "Pay ID";
            this.lb_payId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_header
            // 
            this.lb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(1014, 70);
            this.lb_header.TabIndex = 14;
            this.lb_header.Text = "Pay Details";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS Payroll";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_payId;
        private System.Windows.Forms.Label lb_basic;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TextBox tb_payId;
        private System.Windows.Forms.Label lb_managerId;
        private System.Windows.Forms.Label lb_paymentDate;
        private System.Windows.Forms.Label lb_employeeId;
        private System.Windows.Forms.TextBox tb_managerId;
        private System.Windows.Forms.TextBox tb_basicSalary;
        private System.Windows.Forms.TextBox tb_totalSalary;
        private System.Windows.Forms.TextBox tb_paymentDate;
        private System.Windows.Forms.TextBox tb_employeeId;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_header;
    }
}