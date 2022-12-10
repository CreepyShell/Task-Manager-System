
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
            this.txtProjId = new System.Windows.Forms.TextBox();
            this.btnProjectComplete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(284, 89);
            this.labelProjId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(96, 16);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Enter project id";
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(419, 89);
            this.txtProjId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(132, 22);
            this.txtProjId.TabIndex = 1;
            // 
            // btnProjectComplete
            // 
            this.btnProjectComplete.Location = new System.Drawing.Point(419, 326);
            this.btnProjectComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProjectComplete.Name = "btnProjectComplete";
            this.btnProjectComplete.Size = new System.Drawing.Size(133, 53);
            this.btnProjectComplete.TabIndex = 2;
            this.btnProjectComplete.Text = "Complete project";
            this.btnProjectComplete.UseVisualStyleBackColor = true;
            this.btnProjectComplete.Click += new System.EventHandler(this.btnProjectComplete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmProjectComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProjectComplete);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.labelProjId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProjectComplete";
            this.Text = "frmProjectComplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjId;
        private System.Windows.Forms.TextBox txtProjId;
        private System.Windows.Forms.Button btnProjectComplete;
        private System.Windows.Forms.Button btnBack;
    }
}