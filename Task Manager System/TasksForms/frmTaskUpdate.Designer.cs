
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
            this.labelTaskId.Location = new System.Drawing.Point(54, 40);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(66, 13);
            this.labelTaskId.TabIndex = 0;
            this.labelTaskId.Text = "Choose task";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
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
            this.grpTask.Location = new System.Drawing.Point(89, 137);
            this.grpTask.Name = "grpTask";
            this.grpTask.Size = new System.Drawing.Size(520, 235);
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
            this.txtTaskPriority.Location = new System.Drawing.Point(133, 195);
            this.txtTaskPriority.Name = "txtTaskPriority";
            this.txtTaskPriority.Size = new System.Drawing.Size(121, 21);
            this.txtTaskPriority.TabIndex = 9;
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.FormattingEnabled = true;
            this.txtTaskStatus.Items.AddRange(new object[] {
            "Created",
            "Started",
            "Extended"});
            this.txtTaskStatus.Location = new System.Drawing.Point(133, 157);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.Size = new System.Drawing.Size(121, 21);
            this.txtTaskStatus.TabIndex = 8;
            // 
            // txtTaskHours
            // 
            this.txtTaskHours.Location = new System.Drawing.Point(133, 123);
            this.txtTaskHours.Name = "txtTaskHours";
            this.txtTaskHours.Size = new System.Drawing.Size(100, 20);
            this.txtTaskHours.TabIndex = 7;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(133, 85);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(382, 20);
            this.txtTaskDescription.TabIndex = 6;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(133, 46);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 20);
            this.txtTaskName.TabIndex = 5;
            // 
            // labelTaskPriority
            // 
            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(24, 195);
            this.labelTaskPriority.Name = "labelTaskPriority";
            this.labelTaskPriority.Size = new System.Drawing.Size(38, 13);
            this.labelTaskPriority.TabIndex = 4;
            this.labelTaskPriority.Text = "Priority";
            // 
            // labelTaskStatus
            // 
            this.labelTaskStatus.AutoSize = true;
            this.labelTaskStatus.Location = new System.Drawing.Point(24, 157);
            this.labelTaskStatus.Name = "labelTaskStatus";
            this.labelTaskStatus.Size = new System.Drawing.Size(37, 13);
            this.labelTaskStatus.TabIndex = 3;
            this.labelTaskStatus.Text = "Status";
            // 
            // labelTaskHours
            // 
            this.labelTaskHours.AutoSize = true;
            this.labelTaskHours.Location = new System.Drawing.Point(24, 123);
            this.labelTaskHours.Name = "labelTaskHours";
            this.labelTaskHours.Size = new System.Drawing.Size(35, 13);
            this.labelTaskHours.TabIndex = 2;
            this.labelTaskHours.Text = "Hours";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(24, 85);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(60, 13);
            this.labelTaskDescription.TabIndex = 1;
            this.labelTaskDescription.Text = "Description";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(24, 46);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(35, 13);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Name";
            // 
            // dtnTaskFind
            // 
            this.dtnTaskFind.Location = new System.Drawing.Point(179, 75);
            this.dtnTaskFind.Name = "dtnTaskFind";
            this.dtnTaskFind.Size = new System.Drawing.Size(98, 26);
            this.dtnTaskFind.TabIndex = 4;
            this.dtnTaskFind.Text = "Find task";
            this.dtnTaskFind.UseVisualStyleBackColor = true;
            this.dtnTaskFind.Click += new System.EventHandler(this.dtnTaskFind_Click);
            // 
            // btnSaveTaskDetails
            // 
            this.btnSaveTaskDetails.Location = new System.Drawing.Point(314, 394);
            this.btnSaveTaskDetails.Name = "btnSaveTaskDetails";
            this.btnSaveTaskDetails.Size = new System.Drawing.Size(81, 30);
            this.btnSaveTaskDetails.TabIndex = 5;
            this.btnSaveTaskDetails.Text = "Save task";
            this.btnSaveTaskDetails.UseVisualStyleBackColor = true;
            this.btnSaveTaskDetails.Visible = false;
            this.btnSaveTaskDetails.Click += new System.EventHandler(this.btnSaveTaskDetails_Click);
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(125, 37);
            this.cboTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(546, 21);
            this.cboTask.TabIndex = 6;
            // 
            // frmTaskUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.btnSaveTaskDetails);
            this.Controls.Add(this.dtnTaskFind);
            this.Controls.Add(this.grpTask);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelTaskId);
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