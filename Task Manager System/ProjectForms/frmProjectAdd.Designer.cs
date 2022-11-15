
namespace Task_Manager_System.ProjectForms
{
    partial class frmProjectAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjId = new System.Windows.Forms.TextBox();
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.txtExpectedCost = new System.Windows.Forms.TextBox();
            this.expectedCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project id";
            // 
            // txtProjId
            // 
            this.txtProjId.Enabled = false;
            this.txtProjId.Location = new System.Drawing.Point(204, 41);
            this.txtProjId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(297, 22);
            this.txtProjId.TabIndex = 2;
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(this.btnSaveProject);
            this.grpProject.Controls.Add(this.txtExpectedCost);
            this.grpProject.Controls.Add(this.expectedCost);
            this.grpProject.Controls.Add(this.txtDescription);
            this.grpProject.Controls.Add(this.description);
            this.grpProject.Controls.Add(this.endDate);
            this.grpProject.Controls.Add(this.startDate);
            this.grpProject.Controls.Add(this.dtpDateEnd);
            this.grpProject.Controls.Add(this.dtpDateStart);
            this.grpProject.Controls.Add(this.txtName);
            this.grpProject.Controls.Add(this.label3);
            this.grpProject.Location = new System.Drawing.Point(64, 73);
            this.grpProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProject.Name = "grpProject";
            this.grpProject.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProject.Size = new System.Drawing.Size(947, 390);
            this.grpProject.TabIndex = 3;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Enter details";
            this.grpProject.Enter += new System.EventHandler(this.grpProject_Enter);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(393, 244);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(151, 48);
            this.btnSaveProject.TabIndex = 11;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtExpectedCost
            // 
            this.txtExpectedCost.Location = new System.Drawing.Point(128, 212);
            this.txtExpectedCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpectedCost.Name = "txtExpectedCost";
            this.txtExpectedCost.Size = new System.Drawing.Size(76, 22);
            this.txtExpectedCost.TabIndex = 10;
            // 
            // expectedCost
            // 
            this.expectedCost.AutoSize = true;
            this.expectedCost.Location = new System.Drawing.Point(17, 212);
            this.expectedCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expectedCost.Name = "expectedCost";
            this.expectedCost.Size = new System.Drawing.Size(92, 16);
            this.expectedCost.TabIndex = 9;
            this.expectedCost.Text = "Expected cost";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 79);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(753, 24);
            this.txtDescription.TabIndex = 8;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(17, 82);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(75, 16);
            this.description.TabIndex = 6;
            this.description.Text = "Description";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(17, 170);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(60, 16);
            this.endDate.TabIndex = 5;
            this.endDate.Text = "EndDate";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(17, 123);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(63, 16);
            this.startDate.TabIndex = 4;
            this.startDate.Text = "StartDate";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(128, 162);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateEnd.MinDate = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(268, 22);
            this.dtpDateEnd.TabIndex = 3;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(128, 114);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateStart.MinDate = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(268, 22);
            this.dtpDateStart.TabIndex = 2;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 22);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpProject);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProjectAdd";
            this.Text = "frmProjectAdd";
            this.Load += new System.EventHandler(this.frmProjectAdd_Load);
            this.grpProject.ResumeLayout(false);
            this.grpProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjId;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.TextBox txtExpectedCost;
        private System.Windows.Forms.Label expectedCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label startDate;
    }
}