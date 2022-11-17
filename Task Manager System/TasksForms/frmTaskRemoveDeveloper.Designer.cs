
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
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtDevId = new System.Windows.Forms.TextBox();
            this.labelDevId = new System.Windows.Forms.Label();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAssignDev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(203, 84);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(100, 20);
            this.txtTaskId.TabIndex = 0;
            // 
            // txtDevId
            // 
            this.txtDevId.Location = new System.Drawing.Point(459, 81);
            this.txtDevId.Name = "txtDevId";
            this.txtDevId.Size = new System.Drawing.Size(100, 20);
            this.txtDevId.TabIndex = 1;
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(360, 84);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(93, 13);
            this.labelDevId.TabIndex = 2;
            this.labelDevId.Text = "Enter developer id";
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(102, 84);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(66, 13);
            this.labelTaskId.TabIndex = 3;
            this.labelTaskId.Text = "Enter task id";
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
            // 
            // frmTaskRemoveDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssignDev);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.labelDevId);
            this.Controls.Add(this.txtDevId);
            this.Controls.Add(this.txtTaskId);
            this.Name = "frmTaskRemoveDeveloper";
            this.Text = "frmTaskRemoveDeveloper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.TextBox txtDevId;
        private System.Windows.Forms.Label labelDevId;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAssignDev;
    }
}