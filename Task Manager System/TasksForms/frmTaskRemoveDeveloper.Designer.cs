
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskRemoveDeveloper
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAssignDev = new System.Windows.Forms.Button();
            this.cboTask = new System.Windows.Forms.ComboBox();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(102, 79);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(93, 13);
            this.labelDevId.TabIndex = 2;
            this.labelDevId.Text = "Choose developer";
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(102, 128);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(66, 13);
            this.labelTaskId.TabIndex = 3;
            this.labelTaskId.Text = "Choose task";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAssignDev
            // 
            this.btnAssignDev.Location = new System.Drawing.Point(316, 261);
            this.btnAssignDev.Name = "btnAssignDev";
            this.btnAssignDev.Size = new System.Drawing.Size(103, 40);
            this.btnAssignDev.TabIndex = 5;
            this.btnAssignDev.Text = "Assign developer to chosen task";
            this.btnAssignDev.UseVisualStyleBackColor = true;
            this.btnAssignDev.Click += new System.EventHandler(this.btnAssignDev_Click);
            // 
            // cboTask
            // 
            this.cboTask.FormattingEnabled = true;
            this.cboTask.Location = new System.Drawing.Point(201, 125);
            this.cboTask.Margin = new System.Windows.Forms.Padding(2);
            this.cboTask.Name = "cboTask";
            this.cboTask.Size = new System.Drawing.Size(438, 21);
            this.cboTask.TabIndex = 6;
            // 
            // cboDev
            // 
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(201, 76);
            this.cboDev.Margin = new System.Windows.Forms.Padding(2);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(438, 21);
            this.cboDev.TabIndex = 7;
            this.cboDev.SelectedIndexChanged += new System.EventHandler(this.cboDev_SelectedIndexChanged);
            // 
            // frmTaskRemoveDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDev);
            this.Controls.Add(this.cboTask);
            this.Controls.Add(this.btnAssignDev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.labelDevId);
            this.Name = "frmTaskRemoveDeveloper";
            this.Text = "frmTaskRemoveDeveloper";
            this.Load += new System.EventHandler(this.frmTaskRemoveDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDevId;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAssignDev;
        private System.Windows.Forms.ComboBox cboTask;
        private System.Windows.Forms.ComboBox cboDev;
    }
}