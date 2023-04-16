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
            this.txtMonthRevenue.Location = new System.Drawing.Point(260, 278);
            this.txtMonthRevenue.Name = "txtMonthRevenue";
            this.txtMonthRevenue.ReadOnly = true;
            this.txtMonthRevenue.Size = new System.Drawing.Size(147, 22);
            this.txtMonthRevenue.TabIndex = 14;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(54, 344);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(117, 16);
            this.projectLabel.TabIndex = 12;
            this.projectLabel.Text = "Project information";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(109, 87);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(96, 16);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Enter start date";
            // 
            // btnFindProjects
            // 
            this.btnFindProjects.Location = new System.Drawing.Point(410, 199);
            this.btnFindProjects.Name = "btnFindProjects";
            this.btnFindProjects.Size = new System.Drawing.Size(128, 40);
            this.btnFindProjects.TabIndex = 10;
            this.btnFindProjects.Text = "Find projects";
            this.btnFindProjects.UseVisualStyleBackColor = true;
            this.btnFindProjects.Click += new System.EventHandler(this.btnFindProject_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(109, 140);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(122, 16);
            this.endTimeLabel.TabIndex = 15;
            this.endTimeLabel.Text = "Enter end time date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(249, 80);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 16;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(249, 135);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 17;
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(237, 336);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(475, 24);
            this.cmbProjects.TabIndex = 18;
            // 
            // monthRevenueLabel
            // 
            this.monthRevenueLabel.AutoSize = true;
            this.monthRevenueLabel.Location = new System.Drawing.Point(57, 283);
            this.monthRevenueLabel.Name = "monthRevenueLabel";
            this.monthRevenueLabel.Size = new System.Drawing.Size(95, 16);
            this.monthRevenueLabel.TabIndex = 19;
            this.monthRevenueLabel.Text = "Month revenue";
            // 
            // frmAdminProjectRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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