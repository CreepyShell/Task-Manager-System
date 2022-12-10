
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
            this.txtTaskHours = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelTaskHours = new System.Windows.Forms.Label();
            this.labelTaskStartDate = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtBack = new System.Windows.Forms.Button();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.projIdLabel = new System.Windows.Forms.Label();
            this.txtProjId = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.labelTaskPriority = new System.Windows.Forms.Label();
            this.grpTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTask
            // 
            this.grpTask.Controls.Add(this.txtProjId);
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
            this.grpTask.Location = new System.Drawing.Point(135, 90);
            this.grpTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTask.Name = "grpTask";
            this.grpTask.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTask.Size = new System.Drawing.Size(729, 372);
            this.grpTask.TabIndex = 0;
            this.grpTask.TabStop = false;
            this.grpTask.Text = "Enter new task details";
            // 
            // txtTaskHours
            // 
            this.txtTaskHours.Location = new System.Drawing.Point(204, 146);
            this.txtTaskHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskHours.Name = "txtTaskHours";
            this.txtTaskHours.Size = new System.Drawing.Size(132, 22);
            this.txtTaskHours.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(204, 105);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(265, 22);
            this.dtpStartTime.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(204, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(415, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 22);
            this.txtName.TabIndex = 6;
            // 
            // labelTaskHours
            // 
            this.labelTaskHours.AutoSize = true;
            this.labelTaskHours.Location = new System.Drawing.Point(39, 150);
            this.labelTaskHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskHours.Name = "labelTaskHours";
            this.labelTaskHours.Size = new System.Drawing.Size(102, 16);
            this.labelTaskHours.TabIndex = 4;
            this.labelTaskHours.Text = "Enter task hours";
            // 
            // labelTaskStartDate
            // 
            this.labelTaskStartDate.AutoSize = true;
            this.labelTaskStartDate.Location = new System.Drawing.Point(39, 113);
            this.labelTaskStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskStartDate.Name = "labelTaskStartDate";
            this.labelTaskStartDate.Size = new System.Drawing.Size(124, 16);
            this.labelTaskStartDate.TabIndex = 3;
            this.labelTaskStartDate.Text = "Enter task start date";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(39, 75);
            this.labelTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(135, 16);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = "Enter task description";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(39, 39);
            this.labelTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(103, 16);
            this.labelTaskName.TabIndex = 1;
            this.labelTaskName.Text = "Enter task name";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(311, 302);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 28);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(951, 16);
            this.txtBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(100, 28);
            this.txtBack.TabIndex = 1;
            this.txtBack.Text = "Back";
            this.txtBack.UseVisualStyleBackColor = true;
            this.txtBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(175, 60);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(52, 16);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Task id";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(317, 52);
            this.txtTaskId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(132, 22);
            this.txtTaskId.TabIndex = 3;
            // 
            // projIdLabel
            // 
            this.projIdLabel.AutoSize = true;
            this.projIdLabel.Location = new System.Drawing.Point(43, 227);
            this.projIdLabel.Name = "projIdLabel";
            this.projIdLabel.Size = new System.Drawing.Size(96, 16);
            this.projIdLabel.TabIndex = 11;
            this.projIdLabel.Text = "Enter project id";
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(204, 227);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(207, 22);
            this.txtProjId.TabIndex = 12;
            // 
            // cmbPriority
            // 
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Avarage",
            "Low",
            "Unnecessary"});
            this.cmbPriority.Location = new System.Drawing.Point(204, 187);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(160, 24);
            this.cmbPriority.TabIndex = 10;
            // 
            // labelTaskPriority
            // 
            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(39, 187);
            this.labelTaskPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskPriority.Name = "labelTaskPriority";
            this.labelTaskPriority.Size = new System.Drawing.Size(109, 16);
            this.labelTaskPriority.TabIndex = 5;
            this.labelTaskPriority.Text = "Enter task priority";
            // 
            // frmTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.grpTask);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtProjId;
        private System.Windows.Forms.Label projIdLabel;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label labelTaskPriority;
    }
}