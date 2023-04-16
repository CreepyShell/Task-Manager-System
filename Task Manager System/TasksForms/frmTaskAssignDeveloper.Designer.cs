
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskAssignDeveloper
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
            this.labelDevId = new System.Windows.Forms.Label();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.btnTaskAssignDeveloper = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(150, 161);
            this.labelDevId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(119, 16);
            this.labelDevId.TabIndex = 2;
            this.labelDevId.Text = "Choose developer";
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(150, 111);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(82, 16);
            this.labelTaskId.TabIndex = 3;
            this.labelTaskId.Text = "Choose task";
            // 
            // btnTaskAssignDeveloper
            // 
            this.btnTaskAssignDeveloper.Location = new System.Drawing.Point(427, 368);
            this.btnTaskAssignDeveloper.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaskAssignDeveloper.Name = "btnTaskAssignDeveloper";
            this.btnTaskAssignDeveloper.Size = new System.Drawing.Size(147, 49);
            this.btnTaskAssignDeveloper.TabIndex = 4;
            this.btnTaskAssignDeveloper.Text = "Assign developer to chosen task";
            this.btnTaskAssignDeveloper.UseVisualStyleBackColor = true;
            this.btnTaskAssignDeveloper.Click += new System.EventHandler(this.btnTaskAssignDeveloper_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboDev
            // 
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(303, 158);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(505, 24);
            this.cboDev.TabIndex = 6;
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(303, 103);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(505, 24);
            this.cboTask.TabIndex = 7;
            // 
            // frmTaskAssignDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.cboDev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTaskAssignDeveloper);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.labelDevId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaskAssignDeveloper";
            this.Text = "frmTaskAssignDeveloper";
            this.Load += new System.EventHandler(this.frmTaskAssignDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDevId;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Button btnTaskAssignDeveloper;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboDev;
        private System.Windows.Forms.ComboBox cboTask;
    }
}