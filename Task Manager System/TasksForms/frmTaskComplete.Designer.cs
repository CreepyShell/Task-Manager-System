
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskComplete
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(385, 329);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(85, 32);
            this.btnCompleteTask.TabIndex = 1;
            this.btnCompleteTask.Text = "Complete task";
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(188, 101);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(66, 13);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Enter task id";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(260, 101);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(100, 20);
            this.txtTaskId.TabIndex = 3;
            // 
            // frmTaskComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.btnBack);
            this.Name = "frmTaskComplete";
            this.Text = "frmTaskComplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.TextBox txtTaskId;
    }
}