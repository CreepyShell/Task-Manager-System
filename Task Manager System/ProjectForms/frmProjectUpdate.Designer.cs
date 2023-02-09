
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
            this.btnSaveProj = new System.Windows.Forms.Button();
            this.txtExpectedCost = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExpectedCost = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFindProj = new System.Windows.Forms.Button();
            this.grpProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(73, 24);
            this.labelProjId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(78, 13);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Enter project id";
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(158, 20);
            this.txtProjId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(182, 20);
            this.txtProjId.TabIndex = 1;
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(this.btnSaveProj);
            this.grpProject.Controls.Add(this.txtExpectedCost);
            this.grpProject.Controls.Add(this.txtStatus);
            this.grpProject.Controls.Add(this.dtpEndDate);
            this.grpProject.Controls.Add(this.txtDescription);
            this.grpProject.Controls.Add(this.txtName);
            this.grpProject.Controls.Add(this.labelStatus);
            this.grpProject.Controls.Add(this.labelExpectedCost);
            this.grpProject.Controls.Add(this.labelEndDate);
            this.grpProject.Controls.Add(this.labelDescription);
            this.grpProject.Controls.Add(this.labelName);
            this.grpProject.Location = new System.Drawing.Point(75, 124);
            this.grpProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProject.Name = "grpProject";
            this.grpProject.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpProject.Size = new System.Drawing.Size(490, 270);
            this.grpProject.TabIndex = 2;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Change project details";
            this.grpProject.Visible = false;
            // 
            // btnSaveProj
            // 
            this.btnSaveProj.Location = new System.Drawing.Point(216, 208);
            this.btnSaveProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveProj.Name = "btnSaveProj";
            this.btnSaveProj.Size = new System.Drawing.Size(84, 28);
            this.btnSaveProj.TabIndex = 10;
            this.btnSaveProj.Text = "Save project";
            this.btnSaveProj.UseVisualStyleBackColor = true;
            this.btnSaveProj.Click += new System.EventHandler(this.btnSaveProj_Click);
            // 
            // txtExpectedCost
            // 
            this.txtExpectedCost.Location = new System.Drawing.Point(108, 162);
            this.txtExpectedCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExpectedCost.Name = "txtExpectedCost";
            this.txtExpectedCost.Size = new System.Drawing.Size(157, 20);
            this.txtExpectedCost.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Created",
            "Started",
            "Extended",
            "Finished"});
            this.txtStatus.Location = new System.Drawing.Point(108, 128);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(92, 21);
            this.txtStatus.TabIndex = 8;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(108, 95);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(108, 65);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(378, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 33);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(25, 128);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(70, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "ProjectStatus";
            // 
            // labelExpectedCost
            // 
            this.labelExpectedCost.AutoSize = true;
            this.labelExpectedCost.Location = new System.Drawing.Point(25, 162);
            this.labelExpectedCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpectedCost.Name = "labelExpectedCost";
            this.labelExpectedCost.Size = new System.Drawing.Size(73, 13);
            this.labelExpectedCost.TabIndex = 3;
            this.labelExpectedCost.Text = "ExpectedCost";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(25, 101);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(49, 13);
            this.labelEndDate.TabIndex = 2;
            this.labelEndDate.Text = "EndDate";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoEllipsis = true;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(26, 65);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 33);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(719, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFindProj
            // 
            this.btnFindProj.Location = new System.Drawing.Point(107, 71);
            this.btnFindProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindProj.Name = "btnFindProj";
            this.btnFindProj.Size = new System.Drawing.Size(94, 26);
            this.btnFindProj.TabIndex = 4;
            this.btnFindProj.Text = "Find project";
            this.btnFindProj.UseVisualStyleBackColor = true;
            this.btnFindProj.Click += new System.EventHandler(this.btnFindProj_Click);
            // 
            // frmProjectUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindProj);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpProject);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.labelProjId);
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
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtExpectedCost;
        private System.Windows.Forms.Button btnSaveProj;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindProj;
    }
}