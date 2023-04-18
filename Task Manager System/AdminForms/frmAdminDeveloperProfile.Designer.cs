﻿namespace Task_Manager_System.AdminForms
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFindDeveloper = new System.Windows.Forms.Button();
            this.devIdLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.txtProjectInfo = new System.Windows.Forms.TextBox();
            this.txtTasksInfo = new System.Windows.Forms.ComboBox();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(661, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFindDeveloper
            // 
            this.btnFindDeveloper.Location = new System.Drawing.Point(388, 109);
            this.btnFindDeveloper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindDeveloper.Name = "btnFindDeveloper";
            this.btnFindDeveloper.Size = new System.Drawing.Size(96, 32);
            this.btnFindDeveloper.TabIndex = 2;
            this.btnFindDeveloper.Text = "Find developer";
            this.btnFindDeveloper.UseVisualStyleBackColor = true;
            this.btnFindDeveloper.Click += new System.EventHandler(this.btnFindDeveloper_Click);
            // 
            // devIdLabel
            // 
            this.devIdLabel.AutoSize = true;
            this.devIdLabel.Location = new System.Drawing.Point(88, 37);
            this.devIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.devIdLabel.Name = "devIdLabel";
            this.devIdLabel.Size = new System.Drawing.Size(93, 13);
            this.devIdLabel.TabIndex = 3;
            this.devIdLabel.Text = "Choose developer";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(52, 177);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(94, 13);
            this.projectLabel.TabIndex = 4;
            this.projectLabel.Text = "Project information";
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Location = new System.Drawing.Point(52, 227);
            this.tasksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(161, 13);
            this.tasksLabel.TabIndex = 5;
            this.tasksLabel.Text = "Tasks assigned to the developer";
            // 
            // txtProjectInfo
            // 
            this.txtProjectInfo.Enabled = false;
            this.txtProjectInfo.Location = new System.Drawing.Point(255, 172);
            this.txtProjectInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProjectInfo.Name = "txtProjectInfo";
            this.txtProjectInfo.Size = new System.Drawing.Size(419, 20);
            this.txtProjectInfo.TabIndex = 6;
            // 
            // txtTasksInfo
            // 
            this.txtTasksInfo.FormattingEnabled = true;
            this.txtTasksInfo.Location = new System.Drawing.Point(225, 220);
            this.txtTasksInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTasksInfo.Name = "txtTasksInfo";
            this.txtTasksInfo.Size = new System.Drawing.Size(449, 21);
            this.txtTasksInfo.TabIndex = 7;
            // 
            // cboDev
            // 
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(182, 37);
            this.cboDev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(416, 21);
            this.cboDev.TabIndex = 8;
            // 
            // frmAdminDeveloperProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 435);
            this.Controls.Add(this.cboDev);
            this.Controls.Add(this.txtTasksInfo);
            this.Controls.Add(this.txtProjectInfo);
            this.Controls.Add(this.tasksLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.devIdLabel);
            this.Controls.Add(this.btnFindDeveloper);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminDeveloperProfile";
            this.Text = "frmAdminDeveloperProfile";
            this.Load += new System.EventHandler(this.frmAdminDeveloperProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFindDeveloper;
        private System.Windows.Forms.Label devIdLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.TextBox txtProjectInfo;
        private System.Windows.Forms.ComboBox txtTasksInfo;
        private System.Windows.Forms.ComboBox cboDev;
    }
}