
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
            this.cmbTasksList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtnBack
            // 
            this.dtnBack.Location = new System.Drawing.Point(951, 15);
            this.dtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.dtnBack.Name = "dtnBack";
            this.dtnBack.Size = new System.Drawing.Size(100, 28);
            this.dtnBack.TabIndex = 0;
            this.dtnBack.Text = "Back";
            this.dtnBack.UseVisualStyleBackColor = true;
            this.dtnBack.Click += new System.EventHandler(this.dtnBack_Click);
            // 
            // btnTaskRemove
            // 
            this.btnTaskRemove.Location = new System.Drawing.Point(453, 320);
            this.btnTaskRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaskRemove.Name = "btnTaskRemove";
            this.btnTaskRemove.Size = new System.Drawing.Size(127, 39);
            this.btnTaskRemove.TabIndex = 1;
            this.btnTaskRemove.Text = "Remove task";
            this.btnTaskRemove.UseVisualStyleBackColor = true;
            this.btnTaskRemove.Click += new System.EventHandler(this.btnTaskRemove_Click);
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(66, 68);
            this.labelTaskId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(145, 16);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Choose task to remove";
            // 
            // cmbTasksList
            // 
            this.cmbTasksList.FormattingEnabled = true;
            this.cmbTasksList.Location = new System.Drawing.Point(228, 65);
            this.cmbTasksList.Name = "cmbTasksList";
            this.cmbTasksList.Size = new System.Drawing.Size(650, 24);
            this.cmbTasksList.TabIndex = 3;
            // 
            // frmTaskRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbTasksList);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.btnTaskRemove);
            this.Controls.Add(this.dtnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaskRemove";
            this.Text = "frmTaskRemove";
            this.Load += new System.EventHandler(this.frmTaskRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dtnBack;
        private System.Windows.Forms.Button btnTaskRemove;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.ComboBox cmbTasksList;
    }
}