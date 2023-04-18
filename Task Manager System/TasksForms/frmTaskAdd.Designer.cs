
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskAdd
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
            this.grpTask = new System.Windows.Forms.GroupBox();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.cboProjects = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDevId = new System.Windows.Forms.Label();
            this.projIdLabel = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.txtTaskHours = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelTaskPriority = new System.Windows.Forms.Label();
            this.labelTaskHours = new System.Windows.Forms.Label();
            this.labelTaskStartDate = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtBack = new System.Windows.Forms.Button();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.grpTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTask
            // 
            this.grpTask.Controls.Add(this.cboDev);
            this.grpTask.Controls.Add(this.cboProjects);
            this.grpTask.Controls.Add(this.cboStatus);
            this.grpTask.Controls.Add(this.lblStatus);
            this.grpTask.Controls.Add(this.lblDevId);
            this.grpTask.Controls.Add(this.projIdLabel);
            this.grpTask.Controls.Add(this.cmbPriority);
            this.grpTask.Controls.Add(this.txtTaskHours);
            this.grpTask.Controls.Add(this.dtpStartTime);
            this.grpTask.Controls.Add(this.txtDescription);
            this.grpTask.Controls.Add(this.txtName);
            this.grpTask.Controls.Add(this.labelTaskPriority);
            this.grpTask.Controls.Add(this.labelTaskHours);
            this.grpTask.Controls.Add(this.labelTaskStartDate);
            this.grpTask.Controls.Add(this.labelTaskDescription);
            this.grpTask.Controls.Add(this.labelTaskName);
            this.grpTask.Controls.Add(this.btnAddTask);
            this.grpTask.Location = new System.Drawing.Point(101, 73);
            this.grpTask.Name = "grpTask";
            this.grpTask.Size = new System.Drawing.Size(547, 324);
            this.grpTask.TabIndex = 0;
            this.grpTask.TabStop = false;
            this.grpTask.Text = "Enter new task details";
            this.grpTask.Enter += new System.EventHandler(this.grpTask_Enter);
            // 
            // cboDev
            // 
            this.cboDev.Location = new System.Drawing.Point(153, 252);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(319, 21);
            this.cboDev.TabIndex = 17;
            // 
            // cboProjects
            // 
            this.cboProjects.FormattingEnabled = true;
            this.cboProjects.Location = new System.Drawing.Point(153, 218);
            this.cboProjects.Name = "cboProjects";
            this.cboProjects.Size = new System.Drawing.Size(319, 21);
            this.cboProjects.TabIndex = 4;
            this.cboProjects.SelectedIndexChanged += new System.EventHandler(this.cboProjects_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Created",
            "Started",
            "Extended",
            "Finished"});
            this.cboStatus.Location = new System.Drawing.Point(153, 148);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 16;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Enter task status";
            // 
            // lblDevId
            // 
            this.lblDevId.AutoSize = true;
            this.lblDevId.Location = new System.Drawing.Point(29, 255);
            this.lblDevId.Name = "lblDevId";
            this.lblDevId.Size = new System.Drawing.Size(93, 13);
            this.lblDevId.TabIndex = 13;
            this.lblDevId.Text = "Enter developer id";
            // 
            // projIdLabel
            // 
            this.projIdLabel.AutoSize = true;
            this.projIdLabel.Location = new System.Drawing.Point(30, 218);
            this.projIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projIdLabel.Name = "projIdLabel";
            this.projIdLabel.Size = new System.Drawing.Size(78, 13);
            this.projIdLabel.TabIndex = 11;
            this.projIdLabel.Text = "Enter project id";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low",
            "Unnecessary"});
            this.cmbPriority.Location = new System.Drawing.Point(153, 183);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 10;
            // 
            // txtTaskHours
            // 
            this.txtTaskHours.Location = new System.Drawing.Point(153, 119);
            this.txtTaskHours.Name = "txtTaskHours";
            this.txtTaskHours.Size = new System.Drawing.Size(100, 20);
            this.txtTaskHours.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(153, 85);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtpStartTime.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(153, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(312, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 6;
            // 
            // labelTaskPriority
            // 
            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(29, 183);
            this.labelTaskPriority.Name = "labelTaskPriority";
            this.labelTaskPriority.Size = new System.Drawing.Size(88, 13);
            this.labelTaskPriority.TabIndex = 5;
            this.labelTaskPriority.Text = "Enter task priority";
            // 
            // labelTaskHours
            // 
            this.labelTaskHours.AutoSize = true;
            this.labelTaskHours.Location = new System.Drawing.Point(29, 122);
            this.labelTaskHours.Name = "labelTaskHours";
            this.labelTaskHours.Size = new System.Drawing.Size(84, 13);
            this.labelTaskHours.TabIndex = 4;
            this.labelTaskHours.Text = "Enter task hours";
            // 
            // labelTaskStartDate
            // 
            this.labelTaskStartDate.AutoSize = true;
            this.labelTaskStartDate.Location = new System.Drawing.Point(29, 92);
            this.labelTaskStartDate.Name = "labelTaskStartDate";
            this.labelTaskStartDate.Size = new System.Drawing.Size(102, 13);
            this.labelTaskStartDate.TabIndex = 3;
            this.labelTaskStartDate.Text = "Enter task start date";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(29, 61);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(109, 13);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = "Enter task description";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(29, 32);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(84, 13);
            this.labelTaskName.TabIndex = 1;
            this.labelTaskName.Text = "Enter task name";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(234, 282);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(713, 13);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(75, 23);
            this.txtBack.TabIndex = 1;
            this.txtBack.Text = "Back";
            this.txtBack.UseVisualStyleBackColor = true;
            this.txtBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(131, 49);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(42, 13);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Task id";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(238, 42);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(100, 20);
            this.txtTaskId.TabIndex = 3;
            // 
            // frmTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.grpTask);
            this.Name = "frmTaskAdd";
            this.Text = "frmTaskAdd";
            this.Load += new System.EventHandler(this.frmTaskAdd_Load);
            this.grpTask.ResumeLayout(false);
            this.grpTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button txtBack;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label labelTaskStartDate;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox txtTaskHours;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelTaskHours;
        private System.Windows.Forms.Label projIdLabel;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label labelTaskPriority;
        private System.Windows.Forms.Label lblDevId;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboProjects;
        private System.Windows.Forms.ComboBox cboDev;
    }
}