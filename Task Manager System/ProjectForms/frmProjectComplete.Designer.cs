﻿
namespace Task_Manager_System.ProjectForms
{
    partial class frmProjectComplete
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
            this.labelProjId = new System.Windows.Forms.Label();
            this.btnProjectComplete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(213, 72);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(78, 13);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Choose project";
            // 
            // btnProjectComplete
            // 
            this.btnProjectComplete.Location = new System.Drawing.Point(314, 265);
            this.btnProjectComplete.Name = "btnProjectComplete";
            this.btnProjectComplete.Size = new System.Drawing.Size(100, 43);
            this.btnProjectComplete.TabIndex = 2;
            this.btnProjectComplete.Text = "Complete project";
            this.btnProjectComplete.UseVisualStyleBackColor = true;
            this.btnProjectComplete.Click += new System.EventHandler(this.btnProjectComplete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(297, 69);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(311, 21);
            this.cboProject.TabIndex = 4;
            // 
            // frmProjectComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProjectComplete);
            this.Controls.Add(this.labelProjId);
            this.Name = "frmProjectComplete";
            this.Text = "frmProjectComplete";
            this.Load += new System.EventHandler(this.frmProjectComplete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjId;
        private System.Windows.Forms.Button btnProjectComplete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboProject;
    }
}