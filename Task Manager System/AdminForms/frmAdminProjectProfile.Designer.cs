
namespace Task_Manager_System.AdminForms
{
    partial class frmAdminProjectProfile
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
            this.projIdLabel = new System.Windows.Forms.Label();
            this.btnFindProject = new System.Windows.Forms.Button();
            this.numTasksLabel = new System.Windows.Forms.Label();
            this.tasksHoursLabel = new System.Windows.Forms.Label();
            this.projectDurationLabel = new System.Windows.Forms.Label();
            this.expectedCostLabel = new System.Windows.Forms.Label();
            this.developersLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTasks = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDevelopers = new System.Windows.Forms.ComboBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // projIdLabel
            // 
            this.projIdLabel.AutoSize = true;
            this.projIdLabel.Location = new System.Drawing.Point(60, 54);
            this.projIdLabel.Name = "projIdLabel";
            this.projIdLabel.Size = new System.Drawing.Size(98, 16);
            this.projIdLabel.TabIndex = 0;
            this.projIdLabel.Text = "Choose project";
            // 
            // btnFindProject
            // 
            this.btnFindProject.Location = new System.Drawing.Point(589, 112);
            this.btnFindProject.Name = "btnFindProject";
            this.btnFindProject.Size = new System.Drawing.Size(142, 32);
            this.btnFindProject.TabIndex = 1;
            this.btnFindProject.Text = "Find project";
            this.btnFindProject.UseVisualStyleBackColor = true;
            this.btnFindProject.Click += new System.EventHandler(this.btnFindProject_Click);
            // 
            // numTasksLabel
            // 
            this.numTasksLabel.AutoSize = true;
            this.numTasksLabel.Location = new System.Drawing.Point(101, 198);
            this.numTasksLabel.Name = "numTasksLabel";
            this.numTasksLabel.Size = new System.Drawing.Size(184, 16);
            this.numTasksLabel.TabIndex = 5;
            this.numTasksLabel.Text = "Number of tasks in this project";
            // 
            // tasksHoursLabel
            // 
            this.tasksHoursLabel.AutoSize = true;
            this.tasksHoursLabel.Location = new System.Drawing.Point(104, 241);
            this.tasksHoursLabel.Name = "tasksHoursLabel";
            this.tasksHoursLabel.Size = new System.Drawing.Size(192, 16);
            this.tasksHoursLabel.TabIndex = 6;
            this.tasksHoursLabel.Text = "Hours needed to finish all tasks";
            // 
            // projectDurationLabel
            // 
            this.projectDurationLabel.AutoSize = true;
            this.projectDurationLabel.Location = new System.Drawing.Point(104, 285);
            this.projectDurationLabel.Name = "projectDurationLabel";
            this.projectDurationLabel.Size = new System.Drawing.Size(100, 16);
            this.projectDurationLabel.TabIndex = 7;
            this.projectDurationLabel.Text = "Project duration";
            // 
            // expectedCostLabel
            // 
            this.expectedCostLabel.AutoSize = true;
            this.expectedCostLabel.Location = new System.Drawing.Point(104, 321);
            this.expectedCostLabel.Name = "expectedCostLabel";
            this.expectedCostLabel.Size = new System.Drawing.Size(92, 16);
            this.expectedCostLabel.TabIndex = 8;
            this.expectedCostLabel.Text = "Expected cost";
            // 
            // developersLabel
            // 
            this.developersLabel.AutoSize = true;
            this.developersLabel.Location = new System.Drawing.Point(104, 359);
            this.developersLabel.Name = "developersLabel";
            this.developersLabel.Size = new System.Drawing.Size(218, 16);
            this.developersLabel.TabIndex = 9;
            this.developersLabel.Text = "Developers assigned to this project";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(971, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTasks
            // 
            this.txtTasks.Enabled = false;
            this.txtTasks.Location = new System.Drawing.Point(401, 191);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(100, 22);
            this.txtTasks.TabIndex = 11;
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(401, 234);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 12;
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(418, 278);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(142, 22);
            this.txtDuration.TabIndex = 13;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(401, 314);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(135, 22);
            this.txtCost.TabIndex = 14;
            // 
            // txtDevelopers
            // 
            this.txtDevelopers.FormattingEnabled = true;
            this.txtDevelopers.Location = new System.Drawing.Point(418, 356);
            this.txtDevelopers.Name = "txtDevelopers";
            this.txtDevelopers.Size = new System.Drawing.Size(230, 24);
            this.txtDevelopers.TabIndex = 15;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(199, 46);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(660, 24);
            this.cboProject.TabIndex = 16;
            // 
            // frmAdminProjectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 508);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.txtDevelopers);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtTasks);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.developersLabel);
            this.Controls.Add(this.expectedCostLabel);
            this.Controls.Add(this.projectDurationLabel);
            this.Controls.Add(this.tasksHoursLabel);
            this.Controls.Add(this.numTasksLabel);
            this.Controls.Add(this.btnFindProject);
            this.Controls.Add(this.projIdLabel);
            this.Name = "frmAdminProjectProfile";
            this.Text = "frmAdminProjectProfile";
            this.Load += new System.EventHandler(this.frmAdminProjectProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projIdLabel;
        private System.Windows.Forms.Button btnFindProject;
        private System.Windows.Forms.Label numTasksLabel;
        private System.Windows.Forms.Label tasksHoursLabel;
        private System.Windows.Forms.Label projectDurationLabel;
        private System.Windows.Forms.Label expectedCostLabel;
        private System.Windows.Forms.Label developersLabel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTasks;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox txtDevelopers;
        private System.Windows.Forms.ComboBox cboProject;
    }
}