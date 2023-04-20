
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
            this.cboDevelopers = new System.Windows.Forms.ComboBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevs = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevs)).BeginInit();
            this.SuspendLayout();
            // 
            // projIdLabel
            // 
            this.projIdLabel.AutoSize = true;
            this.projIdLabel.Location = new System.Drawing.Point(45, 44);
            this.projIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projIdLabel.Name = "projIdLabel";
            this.projIdLabel.Size = new System.Drawing.Size(78, 13);
            this.projIdLabel.TabIndex = 0;
            this.projIdLabel.Text = "Choose project";
            // 
            // btnFindProject
            // 
            this.btnFindProject.Location = new System.Drawing.Point(442, 91);
            this.btnFindProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindProject.Name = "btnFindProject";
            this.btnFindProject.Size = new System.Drawing.Size(106, 26);
            this.btnFindProject.TabIndex = 1;
            this.btnFindProject.Text = "Find project";
            this.btnFindProject.UseVisualStyleBackColor = true;
            this.btnFindProject.Click += new System.EventHandler(this.btnFindProject_Click);
            // 
            // numTasksLabel
            // 
            this.numTasksLabel.AutoSize = true;
            this.numTasksLabel.Location = new System.Drawing.Point(76, 161);
            this.numTasksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numTasksLabel.Name = "numTasksLabel";
            this.numTasksLabel.Size = new System.Drawing.Size(149, 13);
            this.numTasksLabel.TabIndex = 5;
            this.numTasksLabel.Text = "Number of tasks in this project";
            // 
            // tasksHoursLabel
            // 
            this.tasksHoursLabel.AutoSize = true;
            this.tasksHoursLabel.Location = new System.Drawing.Point(78, 196);
            this.tasksHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tasksHoursLabel.Name = "tasksHoursLabel";
            this.tasksHoursLabel.Size = new System.Drawing.Size(154, 13);
            this.tasksHoursLabel.TabIndex = 6;
            this.tasksHoursLabel.Text = "Hours needed to finish all tasks";
            // 
            // projectDurationLabel
            // 
            this.projectDurationLabel.AutoSize = true;
            this.projectDurationLabel.Location = new System.Drawing.Point(78, 232);
            this.projectDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectDurationLabel.Name = "projectDurationLabel";
            this.projectDurationLabel.Size = new System.Drawing.Size(81, 13);
            this.projectDurationLabel.TabIndex = 7;
            this.projectDurationLabel.Text = "Project duration";
            // 
            // expectedCostLabel
            // 
            this.expectedCostLabel.AutoSize = true;
            this.expectedCostLabel.Location = new System.Drawing.Point(78, 261);
            this.expectedCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expectedCostLabel.Name = "expectedCostLabel";
            this.expectedCostLabel.Size = new System.Drawing.Size(75, 13);
            this.expectedCostLabel.TabIndex = 8;
            this.expectedCostLabel.Text = "Expected cost";
            // 
            // developersLabel
            // 
            this.developersLabel.AutoSize = true;
            this.developersLabel.Location = new System.Drawing.Point(78, 292);
            this.developersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.developersLabel.Name = "developersLabel";
            this.developersLabel.Size = new System.Drawing.Size(172, 13);
            this.developersLabel.TabIndex = 9;
            this.developersLabel.Text = "Developers assigned to this project";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(728, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTasks
            // 
            this.txtTasks.Enabled = false;
            this.txtTasks.Location = new System.Drawing.Point(301, 155);
            this.txtTasks.Margin = new System.Windows.Forms.Padding(2);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(76, 20);
            this.txtTasks.TabIndex = 11;
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(301, 190);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(76, 20);
            this.txtHours.TabIndex = 12;
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(314, 226);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(108, 20);
            this.txtDuration.TabIndex = 13;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(301, 255);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(102, 20);
            this.txtCost.TabIndex = 14;
            // 
            // cboDevelopers
            // 
            this.cboDevelopers.FormattingEnabled = true;
            this.cboDevelopers.Location = new System.Drawing.Point(314, 289);
            this.cboDevelopers.Margin = new System.Windows.Forms.Padding(2);
            this.cboDevelopers.Name = "cboDevelopers";
            this.cboDevelopers.Size = new System.Drawing.Size(174, 21);
            this.cboDevelopers.TabIndex = 15;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(149, 37);
            this.cboProject.Margin = new System.Windows.Forms.Padding(2);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(496, 21);
            this.cboProject.TabIndex = 16;
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId});
            this.dgvTasks.Location = new System.Drawing.Point(708, 142);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(240, 120);
            this.dgvTasks.TabIndex = 17;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TaskId
            // 
            this.TaskId.HeaderText = "Task id";
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            this.TaskId.Visible = false;
            // 
            // dgvDevs
            // 
            this.dgvDevs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName});
            this.dgvDevs.Location = new System.Drawing.Point(708, 316);
            this.dgvDevs.Name = "dgvDevs";
            this.dgvDevs.Size = new System.Drawing.Size(240, 120);
            this.dgvDevs.TabIndex = 18;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // frmAdminProjectProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 583);
            this.Controls.Add(this.dgvDevs);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.cboDevelopers);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox cboDevelopers;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridView dgvDevs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}