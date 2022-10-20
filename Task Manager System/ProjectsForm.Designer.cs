
namespace Task_Manager_System
{
    partial class ProjectsForm
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
            this.addProjectButton = new System.Windows.Forms.Button();
            this.updateProjectButton = new System.Windows.Forms.Button();
            this.viewProjectProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(129, 45);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(75, 23);
            this.addProjectButton.TabIndex = 0;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // updateProjectButton
            // 
            this.updateProjectButton.Location = new System.Drawing.Point(302, 44);
            this.updateProjectButton.Name = "updateProjectButton";
            this.updateProjectButton.Size = new System.Drawing.Size(135, 23);
            this.updateProjectButton.TabIndex = 1;
            this.updateProjectButton.Text = "Update Project";
            this.updateProjectButton.UseVisualStyleBackColor = true;
            this.updateProjectButton.Click += new System.EventHandler(this.updateProjectButton_Click);
            // 
            // viewProjectProfileButton
            // 
            this.viewProjectProfileButton.Location = new System.Drawing.Point(569, 44);
            this.viewProjectProfileButton.Name = "viewProjectProfileButton";
            this.viewProjectProfileButton.Size = new System.Drawing.Size(131, 23);
            this.viewProjectProfileButton.TabIndex = 2;
            this.viewProjectProfileButton.Text = "View Project Profile";
            this.viewProjectProfileButton.UseVisualStyleBackColor = true;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 538);
            this.Controls.Add(this.viewProjectProfileButton);
            this.Controls.Add(this.updateProjectButton);
            this.Controls.Add(this.addProjectButton);
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button updateProjectButton;
        private System.Windows.Forms.Button viewProjectProfileButton;
    }
}