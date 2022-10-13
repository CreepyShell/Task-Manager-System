
namespace Task_Manager_System
{
    partial class MainMenu
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
            this.tasks = new System.Windows.Forms.Button();
            this.developers = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tasks
            // 
            this.tasks.Location = new System.Drawing.Point(183, 98);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(142, 45);
            this.tasks.TabIndex = 0;
            this.tasks.Text = "Manage Tasks";
            this.tasks.UseVisualStyleBackColor = true;
            this.tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // developers
            // 
            this.developers.Location = new System.Drawing.Point(453, 98);
            this.developers.Name = "developers";
            this.developers.Size = new System.Drawing.Size(142, 45);
            this.developers.TabIndex = 1;
            this.developers.Text = "Manage Developers";
            this.developers.UseVisualStyleBackColor = true;
            this.developers.Click += new System.EventHandler(this.Developers_Click);
            // 
            // projects
            // 
            this.projects.Location = new System.Drawing.Point(703, 98);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(142, 45);
            this.projects.TabIndex = 2;
            this.projects.Text = "Manage Projects";
            this.projects.UseVisualStyleBackColor = true;
            this.projects.Click += new System.EventHandler(this.Projects_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 713);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.developers);
            this.Controls.Add(this.tasks);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tasks;
        private System.Windows.Forms.Button developers;
        private System.Windows.Forms.Button projects;
    }
}

