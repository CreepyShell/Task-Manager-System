
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
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevs = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevs)).BeginInit();
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
            this.btnFindProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindProject.Name = "btnFindProject";
            this.btnFindProject.Size = new System.Drawing.Size(141, 32);
            this.btnFindProject.TabIndex = 1;
            this.btnFindProject.Text = "Find project";
            this.btnFindProject.UseVisualStyleBackColor = true;
            this.btnFindProject.Click += new System.EventHandler(this.btnFindProject_Click);
            // 
            // numTasksLabel
            // 
            this.numTasksLabel.AutoSize = true;
            this.numTasksLabel.Location = new System.Drawing.Point(102, 172);
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
            this.projectDurationLabel.Location = new System.Drawing.Point(104, 286);
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
            this.developersLabel.Location = new System.Drawing.Point(101, 378);
            this.developersLabel.Name = "developersLabel";
            this.developersLabel.Size = new System.Drawing.Size(218, 16);
            this.developersLabel.TabIndex = 9;
            this.developersLabel.Text = "Developers assigned to this project";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(971, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtTasks.Location = new System.Drawing.Point(401, 169);
            this.txtTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(100, 22);
            this.txtTasks.TabIndex = 11;
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(401, 234);
            this.txtHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 12;
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(419, 278);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(143, 22);
            this.txtDuration.TabIndex = 13;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(401, 314);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(135, 22);
            this.txtCost.TabIndex = 14;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(199, 46);
            this.cboProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(660, 24);
            this.cboProject.TabIndex = 16;
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.description,
            this.startDate,
            this.hours,
            this.status,
            this.priority});
            this.dgvTasks.Location = new System.Drawing.Point(384, 538);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.Size = new System.Drawing.Size(857, 148);
            this.dgvTasks.TabIndex = 17;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task name";
            this.TaskName.MinimumWidth = 6;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // hours
            // 
            this.hours.HeaderText = "Hours";
            this.hours.MinimumWidth = 6;
            this.hours.Name = "hours";
            this.hours.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hours.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priority";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 125;
            // 
            // dgvDevs
            // 
            this.dgvDevs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Specialization,
            this.Age});
            this.dgvDevs.Location = new System.Drawing.Point(384, 359);
            this.dgvDevs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevs.Name = "dgvDevs";
            this.dgvDevs.RowHeadersWidth = 51;
            this.dgvDevs.Size = new System.Drawing.Size(564, 148);
            this.dgvDevs.TabIndex = 18;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            this.Specialization.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Specialization.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 125;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(101, 550);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(185, 16);
            this.lblTasks.TabIndex = 19;
            this.lblTasks.Text = "Tasks assigned to this project";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(101, 204);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 16);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Project status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(401, 204);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(135, 22);
            this.txtStatus.TabIndex = 21;
            // 
            // frmAdminProjectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 718);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.dgvDevs);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.cboProject);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminProjectProfile";
            this.Text = "frmAdminProjectProfile";
            this.Load += new System.EventHandler(this.frmAdminProjectProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevs)).EndInit();
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
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridView dgvDevs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}