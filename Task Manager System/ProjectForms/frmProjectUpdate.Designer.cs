
namespace Task_Manager_System.ProjectForms
{
    partial class frmProjectUpdate
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
            this.labelProjId = new System.Windows.Forms.Label();
            this.txtProjId = new System.Windows.Forms.TextBox();
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExpectedCost = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtExpectedCost = new System.Windows.Forms.TextBox();
            this.btnSaveProj = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFindProj = new System.Windows.Forms.Button();
            this.grpProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(97, 30);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(96, 16);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Enter project id";
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(211, 24);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(241, 22);
            this.txtProjId.TabIndex = 1;
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(this.btnSaveProj);
            this.grpProject.Controls.Add(this.txtExpectedCost);
            this.grpProject.Controls.Add(this.comboBox1);
            this.grpProject.Controls.Add(this.dateTimePicker1);
            this.grpProject.Controls.Add(this.txtDescription);
            this.grpProject.Controls.Add(this.txtName);
            this.grpProject.Controls.Add(this.labelStatus);
            this.grpProject.Controls.Add(this.labelExpectedCost);
            this.grpProject.Controls.Add(this.labelEndDate);
            this.grpProject.Controls.Add(this.labelDescription);
            this.grpProject.Controls.Add(this.labelName);
            this.grpProject.Location = new System.Drawing.Point(100, 152);
            this.grpProject.Name = "grpProject";
            this.grpProject.Size = new System.Drawing.Size(653, 332);
            this.grpProject.TabIndex = 2;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Change project details";
            this.grpProject.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Created",
            "Started",
            "Extended",
            "Finished"});
            this.comboBox1.Location = new System.Drawing.Point(144, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(423, 22);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 22);
            this.txtName.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(33, 157);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 16);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "ProjectStatus";
            // 
            // labelExpectedCost
            // 
            this.labelExpectedCost.AutoSize = true;
            this.labelExpectedCost.Location = new System.Drawing.Point(33, 200);
            this.labelExpectedCost.Name = "labelExpectedCost";
            this.labelExpectedCost.Size = new System.Drawing.Size(91, 16);
            this.labelExpectedCost.TabIndex = 3;
            this.labelExpectedCost.Text = "ExpectedCost";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(33, 124);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(60, 16);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "EndDate";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(34, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(34, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // txtExpectedCost
            // 
            this.txtExpectedCost.Location = new System.Drawing.Point(144, 200);
            this.txtExpectedCost.Name = "txtExpectedCost";
            this.txtExpectedCost.Size = new System.Drawing.Size(208, 22);
            this.txtExpectedCost.TabIndex = 9;
            // 
            // btnSaveProj
            // 
            this.btnSaveProj.Location = new System.Drawing.Point(288, 256);
            this.btnSaveProj.Name = "btnSaveProj";
            this.btnSaveProj.Size = new System.Drawing.Size(112, 35);
            this.btnSaveProj.TabIndex = 10;
            this.btnSaveProj.Text = "Save project";
            this.btnSaveProj.UseVisualStyleBackColor = true;
            this.btnSaveProj.Click += new System.EventHandler(this.btnSaveProj_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(959, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFindProj
            // 
            this.btnFindProj.Location = new System.Drawing.Point(143, 87);
            this.btnFindProj.Name = "btnFindProj";
            this.btnFindProj.Size = new System.Drawing.Size(125, 32);
            this.btnFindProj.TabIndex = 4;
            this.btnFindProj.Text = "Find project";
            this.btnFindProj.UseVisualStyleBackColor = true;
            this.btnFindProj.Click += new System.EventHandler(this.btnFindProj_Click);
            // 
            // frmProjectUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFindProj);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpProject);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.labelProjId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProjectUpdate";
            this.Text = "frmProjectUpdate";
            this.Load += new System.EventHandler(this.frmProjectUpdate_Load);
            this.grpProject.ResumeLayout(false);
            this.grpProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjId;
        private System.Windows.Forms.TextBox txtProjId;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelExpectedCost;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtExpectedCost;
        private System.Windows.Forms.Button btnSaveProj;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindProj;
    }
}