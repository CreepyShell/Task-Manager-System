
namespace Task_Manager_System
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDeveloperToAProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeAProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeveloperProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMonthRevenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.developersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.updateProjectToolStripMenuItem,
            this.assignDeveloperToAProjectToolStripMenuItem,
            this.completeAProjectToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // updateProjectToolStripMenuItem
            // 
            this.updateProjectToolStripMenuItem.Name = "updateProjectToolStripMenuItem";
            this.updateProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateProjectToolStripMenuItem.Text = "Update Project";
            // 
            // assignDeveloperToAProjectToolStripMenuItem
            // 
            this.assignDeveloperToAProjectToolStripMenuItem.Name = "assignDeveloperToAProjectToolStripMenuItem";
            this.assignDeveloperToAProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignDeveloperToAProjectToolStripMenuItem.Text = "Assign Developer";
            // 
            // completeAProjectToolStripMenuItem
            // 
            this.completeAProjectToolStripMenuItem.Name = "completeAProjectToolStripMenuItem";
            this.completeAProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completeAProjectToolStripMenuItem.Text = "Complete a Project";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.updateTaskToolStripMenuItem,
            this.removeTaskToolStripMenuItem,
            this.assignDeveloperToolStripMenuItem,
            this.removeDeveloperToolStripMenuItem,
            this.completeTaskToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addTaskToolStripMenuItem.Text = "Add Task";
            // 
            // updateTaskToolStripMenuItem
            // 
            this.updateTaskToolStripMenuItem.Name = "updateTaskToolStripMenuItem";
            this.updateTaskToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateTaskToolStripMenuItem.Text = "Update Task";
            // 
            // removeTaskToolStripMenuItem
            // 
            this.removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            this.removeTaskToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeTaskToolStripMenuItem.Text = "Remove Task";
            // 
            // assignDeveloperToolStripMenuItem
            // 
            this.assignDeveloperToolStripMenuItem.Name = "assignDeveloperToolStripMenuItem";
            this.assignDeveloperToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.assignDeveloperToolStripMenuItem.Text = "Assign Developer";
            // 
            // removeDeveloperToolStripMenuItem
            // 
            this.removeDeveloperToolStripMenuItem.Name = "removeDeveloperToolStripMenuItem";
            this.removeDeveloperToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeDeveloperToolStripMenuItem.Text = "Remove Developer";
            // 
            // completeTaskToolStripMenuItem
            // 
            this.completeTaskToolStripMenuItem.Name = "completeTaskToolStripMenuItem";
            this.completeTaskToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.completeTaskToolStripMenuItem.Text = "Complete Task";
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProjectProfileToolStripMenuItem,
            this.showDeveloperProfileToolStripMenuItem,
            this.showMonthRevenueToolStripMenuItem});
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.developersToolStripMenuItem.Text = "Admin";
            // 
            // showProjectProfileToolStripMenuItem
            // 
            this.showProjectProfileToolStripMenuItem.Name = "showProjectProfileToolStripMenuItem";
            this.showProjectProfileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showProjectProfileToolStripMenuItem.Text = "Show project profile";
            // 
            // showDeveloperProfileToolStripMenuItem
            // 
            this.showDeveloperProfileToolStripMenuItem.Name = "showDeveloperProfileToolStripMenuItem";
            this.showDeveloperProfileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showDeveloperProfileToolStripMenuItem.Text = "Show developer profile";
            // 
            // showMonthRevenueToolStripMenuItem
            // 
            this.showMonthRevenueToolStripMenuItem.Name = "showMonthRevenueToolStripMenuItem";
            this.showMonthRevenueToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showMonthRevenueToolStripMenuItem.Text = "Show month revenue";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 713);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDeveloperToAProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeAProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProjectProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeveloperProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMonthRevenueToolStripMenuItem;
    }
}

