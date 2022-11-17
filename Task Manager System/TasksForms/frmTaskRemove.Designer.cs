
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskRemove
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
            this.dtnBack = new System.Windows.Forms.Button();
            this.btnTaskRemove = new System.Windows.Forms.Button();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtnBack
            // 
            this.dtnBack.Location = new System.Drawing.Point(713, 12);
            this.dtnBack.Name = "dtnBack";
            this.dtnBack.Size = new System.Drawing.Size(75, 23);
            this.dtnBack.TabIndex = 0;
            this.dtnBack.Text = "Back";
            this.dtnBack.UseVisualStyleBackColor = true;
            this.dtnBack.Click += new System.EventHandler(this.dtnBack_Click);
            // 
            // btnTaskRemove
            // 
            this.btnTaskRemove.Location = new System.Drawing.Point(340, 260);
            this.btnTaskRemove.Name = "btnTaskRemove";
            this.btnTaskRemove.Size = new System.Drawing.Size(95, 32);
            this.btnTaskRemove.TabIndex = 1;
            this.btnTaskRemove.Text = "Remove task";
            this.btnTaskRemove.UseVisualStyleBackColor = true;
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(236, 71);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(66, 13);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Enter task id";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(322, 71);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(100, 20);
            this.txtTaskId.TabIndex = 3;
            // 
            // frmTaskRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.btnTaskRemove);
            this.Controls.Add(this.dtnBack);
            this.Name = "frmTaskRemove";
            this.Text = "frmTaskRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dtnBack;
        private System.Windows.Forms.Button btnTaskRemove;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.TextBox txtTaskId;
    }
}