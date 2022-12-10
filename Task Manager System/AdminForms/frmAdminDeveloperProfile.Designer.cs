namespace Task_Manager_System.AdminForms
{
    partial class frmAdminDeveloperProfile
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
            this.txtDevid = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFindDeveloper = new System.Windows.Forms.Button();
            this.devIdLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.txtProjectInfo = new System.Windows.Forms.TextBox();
            this.txtTasksInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDevid
            // 
            this.txtDevid.Location = new System.Drawing.Point(257, 46);
            this.txtDevid.Name = "txtDevid";
            this.txtDevid.Size = new System.Drawing.Size(195, 22);
            this.txtDevid.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(881, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFindDeveloper
            // 
            this.btnFindDeveloper.Location = new System.Drawing.Point(517, 134);
            this.btnFindDeveloper.Name = "btnFindDeveloper";
            this.btnFindDeveloper.Size = new System.Drawing.Size(128, 40);
            this.btnFindDeveloper.TabIndex = 2;
            this.btnFindDeveloper.Text = "Find developer";
            this.btnFindDeveloper.UseVisualStyleBackColor = true;
            this.btnFindDeveloper.Click += new System.EventHandler(this.btnFindDeveloper_Click);
            // 
            // devIdLabel
            // 
            this.devIdLabel.AutoSize = true;
            this.devIdLabel.Location = new System.Drawing.Point(118, 46);
            this.devIdLabel.Name = "devIdLabel";
            this.devIdLabel.Size = new System.Drawing.Size(117, 16);
            this.devIdLabel.TabIndex = 3;
            this.devIdLabel.Text = "Enter developer id";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(70, 218);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(117, 16);
            this.projectLabel.TabIndex = 4;
            this.projectLabel.Text = "Project information";
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Location = new System.Drawing.Point(70, 279);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(204, 16);
            this.tasksLabel.TabIndex = 5;
            this.tasksLabel.Text = "Tasks assigned to the developer";
            // 
            // txtProjectInfo
            // 
            this.txtProjectInfo.Location = new System.Drawing.Point(340, 212);
            this.txtProjectInfo.Name = "txtProjectInfo";
            this.txtProjectInfo.Size = new System.Drawing.Size(557, 22);
            this.txtProjectInfo.TabIndex = 6;
            // 
            // txtTasksInfo
            // 
            this.txtTasksInfo.FormattingEnabled = true;
            this.txtTasksInfo.Location = new System.Drawing.Point(300, 271);
            this.txtTasksInfo.Name = "txtTasksInfo";
            this.txtTasksInfo.Size = new System.Drawing.Size(597, 24);
            this.txtTasksInfo.TabIndex = 7;
            // 
            // frmAdminDeveloperProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 535);
            this.Controls.Add(this.txtTasksInfo);
            this.Controls.Add(this.txtProjectInfo);
            this.Controls.Add(this.tasksLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.devIdLabel);
            this.Controls.Add(this.btnFindDeveloper);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDevid);
            this.Name = "frmAdminDeveloperProfile";
            this.Text = "frmAdminDeveloperProfile";
            this.Load += new System.EventHandler(this.frmAdminDeveloperProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDevid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindDeveloper;
        private System.Windows.Forms.Label devIdLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.TextBox txtProjectInfo;
        private System.Windows.Forms.ComboBox txtTasksInfo;
    }
}