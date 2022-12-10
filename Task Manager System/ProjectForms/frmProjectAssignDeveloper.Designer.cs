
namespace Task_Manager_System.ProjectForms
{
    partial class frmProjectAssignDeveloper
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
            this.labelDevId = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtDevId = new System.Windows.Forms.TextBox();
            this.txtProjId = new System.Windows.Forms.TextBox();
            this.dtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(33, 85);
            this.labelProjId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(96, 16);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Enter project id";
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(452, 80);
            this.labelDevId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(117, 16);
            this.labelDevId.TabIndex = 1;
            this.labelDevId.Text = "Enter developer id";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(336, 372);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(172, 49);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign developer to chosen project";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtDevId
            // 
            this.txtDevId.Location = new System.Drawing.Point(584, 76);
            this.txtDevId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDevId.Name = "txtDevId";
            this.txtDevId.Size = new System.Drawing.Size(257, 22);
            this.txtDevId.TabIndex = 3;
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(171, 76);
            this.txtProjId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(205, 22);
            this.txtProjId.TabIndex = 4;
            // 
            // dtnBack
            // 
            this.dtnBack.Location = new System.Drawing.Point(951, 2);
            this.dtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtnBack.Name = "dtnBack";
            this.dtnBack.Size = new System.Drawing.Size(100, 28);
            this.dtnBack.TabIndex = 5;
            this.dtnBack.Text = "Back";
            this.dtnBack.UseVisualStyleBackColor = true;
            this.dtnBack.Click += new System.EventHandler(this.dtnBack_Click);
            // 
            // frmProjectAssignDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dtnBack);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.txtDevId);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.labelDevId);
            this.Controls.Add(this.labelProjId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProjectAssignDeveloper";
            this.Text = "frmProjectAssignDeveloper";
            this.Load += new System.EventHandler(this.frmProjectAssignDeveloper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjId;
        private System.Windows.Forms.Label labelDevId;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtDevId;
        private System.Windows.Forms.TextBox txtProjId;
        private System.Windows.Forms.Button dtnBack;
    }
}