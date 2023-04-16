
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskUpdate
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
            this.labelTaskId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpTask = new System.Windows.Forms.GroupBox();
            this.txtTaskPriority = new System.Windows.Forms.ComboBox();
            this.txtTaskStatus = new System.Windows.Forms.ComboBox();
            this.txtTaskHours = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.labelTaskPriority = new System.Windows.Forms.Label();
            this.labelTaskStatus = new System.Windows.Forms.Label();
            this.labelTaskHours = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.dtnTaskFind = new System.Windows.Forms.Button();
            this.btnSaveTaskDetails = new System.Windows.Forms.Button();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.grpTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(129, 49);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(82, 16);
            this.labelTaskId.TabIndex = 0;
            this.labelTaskId.Text = "Choose task";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpTask
            // 
            this.grpTask.Controls.Add(this.txtTaskPriority);
            this.grpTask.Controls.Add(this.txtTaskStatus);
            this.grpTask.Controls.Add(this.txtTaskHours);
            this.grpTask.Controls.Add(this.txtTaskDescription);
            this.grpTask.Controls.Add(this.txtTaskName);
            this.grpTask.Controls.Add(this.labelTaskPriority);
            this.grpTask.Controls.Add(this.labelTaskStatus);
            this.grpTask.Controls.Add(this.labelTaskHours);
            this.grpTask.Controls.Add(this.labelTaskDescription);
            this.grpTask.Controls.Add(this.labelTaskName);
            this.grpTask.Location = new System.Drawing.Point(119, 169);
            this.grpTask.Margin = new System.Windows.Forms.Padding(4);
            this.grpTask.Name = "grpTask";
            this.grpTask.Padding = new System.Windows.Forms.Padding(4);
            this.grpTask.Size = new System.Drawing.Size(693, 289);
            this.grpTask.TabIndex = 3;
            this.grpTask.TabStop = false;
            this.grpTask.Text = "Update task details";
            this.grpTask.Visible = false;
            // 
            // txtTaskPriority
            // 
            this.txtTaskPriority.FormattingEnabled = true;
            this.txtTaskPriority.Items.AddRange(new object[] {
            "High",
            "Avarage",
            "Low",
            "Unnecessary"});
            this.txtTaskPriority.Location = new System.Drawing.Point(177, 240);
            this.txtTaskPriority.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskPriority.Name = "txtTaskPriority";
            this.txtTaskPriority.Size = new System.Drawing.Size(160, 24);
            this.txtTaskPriority.TabIndex = 9;
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.FormattingEnabled = true;
            this.txtTaskStatus.Items.AddRange(new object[] {
            "Created",
            "Started",
            "Extended"});
            this.txtTaskStatus.Location = new System.Drawing.Point(177, 193);
            this.txtTaskStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.Size = new System.Drawing.Size(160, 24);
            this.txtTaskStatus.TabIndex = 8;
            // 
            // txtTaskHours
            // 
            this.txtTaskHours.Location = new System.Drawing.Point(177, 151);
            this.txtTaskHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskHours.Name = "txtTaskHours";
            this.txtTaskHours.Size = new System.Drawing.Size(132, 22);
            this.txtTaskHours.TabIndex = 7;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(177, 105);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(508, 22);
            this.txtTaskDescription.TabIndex = 6;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(177, 57);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(132, 22);
            this.txtTaskName.TabIndex = 5;
            // 
            // labelTaskPriority
            // 
            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(32, 240);
            this.labelTaskPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskPriority.Name = "labelTaskPriority";
            this.labelTaskPriority.Size = new System.Drawing.Size(48, 16);
            this.labelTaskPriority.TabIndex = 4;
            this.labelTaskPriority.Text = "Priority";
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Location = new System.Drawing.Point(32, 193);
            this.labelTaskStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(44, 16);
            this.labelTaskStatus.TabIndex = 3;
            this.labelTaskStatus.Text = "Status";
            // 
            // labelTaskHours
            // 
            this.labelTaskHours.AutoSize = true;
            this.labelTaskHours.Location = new System.Drawing.Point(32, 151);
            this.labelTaskHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskHours.Name = "labelTaskHours";
            this.labelTaskHours.Size = new System.Drawing.Size(43, 16);
            this.labelTaskHours.TabIndex = 2;
            this.labelTaskHours.Text = "Hours";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(32, 105);
            this.labelTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(75, 16);
            this.labelTaskDescription.TabIndex = 1;
            this.labelTaskDescription.Text = "Description";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(32, 57);
            this.labelTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(44, 16);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Name";
            // 
            // dtnTaskFind
            // 
            this.dtnTaskFind.Location = new System.Drawing.Point(239, 92);
            this.dtnTaskFind.Margin = new System.Windows.Forms.Padding(4);
            this.dtnTaskFind.Name = "dtnTaskFind";
            this.dtnTaskFind.Size = new System.Drawing.Size(131, 32);
            this.dtnTaskFind.TabIndex = 4;
            this.dtnTaskFind.Text = "Find task";
            this.dtnTaskFind.UseVisualStyleBackColor = true;
            this.dtnTaskFind.Click += new System.EventHandler(this.dtnTaskFind_Click);
            // 
            // btnSaveTaskDetails
            // 
            this.btnSaveTaskDetails.Location = new System.Drawing.Point(419, 485);
            this.btnSaveTaskDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTaskDetails.Name = "btnSaveTaskDetails";
            this.btnSaveTaskDetails.Size = new System.Drawing.Size(108, 37);
            this.btnSaveTaskDetails.TabIndex = 5;
            this.btnSaveTaskDetails.Text = "Save task";
            this.btnSaveTaskDetails.UseVisualStyleBackColor = true;
            this.btnSaveTaskDetails.Visible = false;
            this.btnSaveTaskDetails.Click += new System.EventHandler(this.btnSaveTaskDetails_Click);
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(239, 46);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(592, 24);
            this.cboTask.TabIndex = 6;
            // 
            // frmTaskUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.btnSaveTaskDetails);
            this.Controls.Add(this.dtnTaskFind);
            this.Controls.Add(this.grpTask);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelTaskId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaskUpdate";
            this.Text = "frmUpdateTask";
            this.Load += new System.EventHandler(this.frmUpdateTask_Load);
            this.grpTask.ResumeLayout(false);
            this.grpTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpTask;
        private System.Windows.Forms.ComboBox txtTaskPriority;
        private System.Windows.Forms.ComboBox txtTaskStatus;
        private System.Windows.Forms.TextBox txtTaskHours;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label labelTaskPriority;
        private System.Windows.Forms.Label labelTaskStatus;
        private System.Windows.Forms.Label labelTaskHours;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.Button dtnTaskFind;
        private System.Windows.Forms.Button btnSaveTaskDetails;
        private System.Windows.Forms.ComboBox cboTask;
    }
}