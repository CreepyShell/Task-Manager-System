namespace Task_Manager_System.AdminForms
{
    partial class frmAdminProjectRevenue
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
            this.txtMonthRevenue = new System.Windows.Forms.TextBox();
            this.projectLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.btnFindProjects = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.monthRevenueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonthRevenue
            // 
            this.txtMonthRevenue.Location = new System.Drawing.Point(195, 226);
            this.txtMonthRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonthRevenue.Name = "txtMonthRevenue";
            this.txtMonthRevenue.ReadOnly = true;
            this.txtMonthRevenue.Size = new System.Drawing.Size(143, 20);
            this.txtMonthRevenue.TabIndex = 14;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(11, 281);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(99, 13);
            this.projectLabel.TabIndex = 12;
            this.projectLabel.Text = "Projects information";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(82, 71);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(79, 13);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Enter start date";
            // 
            // btnFindProjects
            // 
            this.btnFindProjects.Location = new System.Drawing.Point(308, 162);
            this.btnFindProjects.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindProjects.Name = "btnFindProjects";
            this.btnFindProjects.Size = new System.Drawing.Size(96, 32);
            this.btnFindProjects.TabIndex = 10;
            this.btnFindProjects.Text = "Find projects";
            this.btnFindProjects.UseVisualStyleBackColor = true;
            this.btnFindProjects.Click += new System.EventHandler(this.btnFindProject_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(535, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(82, 114);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(99, 13);
            this.endTimeLabel.TabIndex = 15;
            this.endTimeLabel.Text = "Enter end time date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(187, 65);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 20);
            this.dtpStartDate.TabIndex = 16;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(187, 110);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEndDate.TabIndex = 17;
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(109, 273);
            this.cmbProjects.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(480, 21);
            this.cmbProjects.TabIndex = 18;
            // 
            // monthRevenueLabel
            // 
            this.monthRevenueLabel.AutoSize = true;
            this.monthRevenueLabel.Location = new System.Drawing.Point(43, 230);
            this.monthRevenueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthRevenueLabel.Name = "monthRevenueLabel";
            this.monthRevenueLabel.Size = new System.Drawing.Size(79, 13);
            this.monthRevenueLabel.TabIndex = 19;
            this.monthRevenueLabel.Text = "Month revenue";
            // 
            // frmAdminProjectRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.monthRevenueLabel);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.txtMonthRevenue);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.btnFindProjects);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminProjectRevenue";
            this.Text = "frmAdminProjectRevenue";
            this.Load += new System.EventHandler(this.frmAdminProjectRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMonthRevenue;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Button btnFindProjects;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label monthRevenueLabel;
    }
}