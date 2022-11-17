
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
            this.labelProjId.Location = new System.Drawing.Point(25, 69);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(78, 13);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Enter project id";
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(339, 65);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(93, 13);
            this.labelDevId.TabIndex = 1;
            this.labelDevId.Text = "Enter developer id";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(252, 302);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(129, 40);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign developer to chosen project";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // txtDevId
            // 
            this.txtDevId.Location = new System.Drawing.Point(438, 62);
            this.txtDevId.Name = "txtDevId";
            this.txtDevId.Size = new System.Drawing.Size(194, 20);
            this.txtDevId.TabIndex = 3;
            // 
            // txtProjId
            // 
            this.txtProjId.Location = new System.Drawing.Point(128, 62);
            this.txtProjId.Name = "txtProjId";
            this.txtProjId.Size = new System.Drawing.Size(155, 20);
            this.txtProjId.TabIndex = 4;
            // 
            // dtnBack
            // 
            this.dtnBack.Location = new System.Drawing.Point(713, 2);
            this.dtnBack.Name = "dtnBack";
            this.dtnBack.Size = new System.Drawing.Size(75, 23);
            this.dtnBack.TabIndex = 5;
            this.dtnBack.Text = "Back";
            this.dtnBack.UseVisualStyleBackColor = true;
            this.dtnBack.Click += new System.EventHandler(this.dtnBack_Click);
            // 
            // frmProjectAssignDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtnBack);
            this.Controls.Add(this.txtProjId);
            this.Controls.Add(this.txtDevId);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.labelDevId);
            this.Controls.Add(this.labelProjId);
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