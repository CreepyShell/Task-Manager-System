
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
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtDevId = new System.Windows.Forms.TextBox();
            this.labelDevId = new System.Windows.Forms.Label();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.btnTaskAssignDeveloper = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(279, 110);
            this.txtTaskId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(132, 22);
            this.txtTaskId.TabIndex = 0;
            // 
            // txtDevId
            // 
            this.txtDevId.Location = new System.Drawing.Point(616, 108);
            this.txtDevId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDevId.Name = "txtDevId";
            this.txtDevId.Size = new System.Drawing.Size(132, 22);
            this.txtDevId.TabIndex = 1;
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(471, 117);
            this.labelDevId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(117, 16);
            this.labelDevId.TabIndex = 2;
            this.labelDevId.Text = "Enter developer id";
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(173, 118);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(80, 16);
            this.labelTaskId.TabIndex = 3;
            this.labelTaskId.Text = "Enter task id";
            // 
            // btnTaskAssignDeveloper
            // 
            this.btnTaskAssignDeveloper.Location = new System.Drawing.Point(427, 368);
            this.btnTaskAssignDeveloper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTaskAssignDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTaskAssignDeveloper);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.labelDevId);
            this.Controls.Add(this.txtDevId);
            this.Controls.Add(this.txtTaskId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTaskAssignDeveloper";
            this.Text = "frmTaskAssignDeveloper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.TextBox txtDevId;
        private System.Windows.Forms.Label labelDevId;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Button btnTaskAssignDeveloper;
        private System.Windows.Forms.Button btnBack;
    }
}