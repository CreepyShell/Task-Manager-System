
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
            this.dtnBack = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbDev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelProjId
            // 
            this.labelProjId.AutoSize = true;
            this.labelProjId.Location = new System.Drawing.Point(119, 115);
            this.labelProjId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjId.Name = "labelProjId";
            this.labelProjId.Size = new System.Drawing.Size(98, 16);
            this.labelProjId.TabIndex = 0;
            this.labelProjId.Text = "Choose project";
            // 
            // labelDevId
            // 
            this.labelDevId.AutoSize = true;
            this.labelDevId.Location = new System.Drawing.Point(119, 174);
            this.labelDevId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevId.Name = "labelDevId";
            this.labelDevId.Size = new System.Drawing.Size(119, 16);
            this.labelDevId.TabIndex = 1;
            this.labelDevId.Text = "Choose developer";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(336, 372);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(172, 49);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign developer to chosen project";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dtnBack
            // 
            this.dtnBack.Location = new System.Drawing.Point(951, 2);
            this.dtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.dtnBack.Name = "dtnBack";
            this.dtnBack.Size = new System.Drawing.Size(100, 28);
            this.dtnBack.TabIndex = 5;
            this.dtnBack.Text = "Back";
            this.dtnBack.UseVisualStyleBackColor = true;
            this.dtnBack.Click += new System.EventHandler(this.dtnBack_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(285, 115);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(566, 24);
            this.cmbProject.TabIndex = 6;
            // 
            // cmbDev
            // 
            this.cmbDev.FormattingEnabled = true;
            this.cmbDev.Location = new System.Drawing.Point(285, 165);
            this.cmbDev.Name = "cmbDev";
            this.cmbDev.Size = new System.Drawing.Size(566, 24);
            this.cmbDev.TabIndex = 8;
            // 
            // frmProjectAssignDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbDev);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.dtnBack);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.labelDevId);
            this.Controls.Add(this.labelProjId);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button dtnBack;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbDev;
    }
}