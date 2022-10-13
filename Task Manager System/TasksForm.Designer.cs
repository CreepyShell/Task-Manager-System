
namespace Task_Manager_System
{
    partial class TasksForm
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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.updateTaskButton = new System.Windows.Forms.Button();
            this.viewProjectProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(82, 22);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            // 
            // updateTaskButton
            // 
            this.updateTaskButton.Location = new System.Drawing.Point(218, 21);
            this.updateTaskButton.Name = "updateTaskButton";
            this.updateTaskButton.Size = new System.Drawing.Size(199, 23);
            this.updateTaskButton.TabIndex = 1;
            this.updateTaskButton.Text = "Update Task";
            this.updateTaskButton.UseVisualStyleBackColor = true;
            // 
            // viewProjectProfileButton
            // 
            this.viewProjectProfileButton.Location = new System.Drawing.Point(477, 21);
            this.viewProjectProfileButton.Name = "viewProjectProfileButton";
            this.viewProjectProfileButton.Size = new System.Drawing.Size(114, 23);
            this.viewProjectProfileButton.TabIndex = 2;
            this.viewProjectProfileButton.Text = "View Project Profile";
            this.viewProjectProfileButton.UseVisualStyleBackColor = true;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 430);
            this.Controls.Add(this.viewProjectProfileButton);
            this.Controls.Add(this.updateTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button updateTaskButton;
        private System.Windows.Forms.Button viewProjectProfileButton;
    }
}