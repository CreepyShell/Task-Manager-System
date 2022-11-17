
namespace Task_Manager_System.TasksForms
{
    partial class frmTaskAdd
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
            this.grpTask = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTaskPriority = new System.Windows.Forms.Label();
            this.labelTaskHours = new System.Windows.Forms.Label();
            this.labelTaskStartDate = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtBack = new System.Windows.Forms.Button();
            this.labelTaskId = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.grpTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTask
            // 
            this.grpTask.Controls.Add(this.comboBox1);
            this.grpTask.Controls.Add(this.textBox4);
            this.grpTask.Controls.Add(this.dateTimePicker1);
            this.grpTask.Controls.Add(this.textBox3);
            this.grpTask.Controls.Add(this.textBox2);
            this.grpTask.Controls.Add(this.labelTaskPriority);
            this.grpTask.Controls.Add(this.labelTaskHours);
            this.grpTask.Controls.Add(this.labelTaskStartDate);
            this.grpTask.Controls.Add(this.labelTaskDescription);
            this.grpTask.Controls.Add(this.labelTaskName);
            this.grpTask.Controls.Add(this.btnAddTask);
            this.grpTask.Location = new System.Drawing.Point(101, 73);
            this.grpTask.Name = "grpTask";
            this.grpTask.Size = new System.Drawing.Size(547, 302);
            this.grpTask.TabIndex = 0;
            this.grpTask.TabStop = false;
            this.grpTask.Text = "Enter new task details";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High",
            "Avarage",
            "Low",
            "Unnecessary"});
            this.comboBox1.Location = new System.Drawing.Point(153, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 6;
            // 
            // labelTaskPriority
            // 
            this.labelTaskPriority.AutoSize = true;
            this.labelTaskPriority.Location = new System.Drawing.Point(29, 152);
            this.labelTaskPriority.Name = "labelTaskPriority";
            this.labelTaskPriority.Size = new System.Drawing.Size(88, 13);
            this.labelTaskPriority.TabIndex = 5;
            this.labelTaskPriority.Text = "Enter task priority";
            // 
            // labelTaskHours
            // 
            this.labelTaskHours.AutoSize = true;
            this.labelTaskHours.Location = new System.Drawing.Point(29, 122);
            this.labelTaskHours.Name = "labelTaskHours";
            this.labelTaskHours.Size = new System.Drawing.Size(84, 13);
            this.labelTaskHours.TabIndex = 4;
            this.labelTaskHours.Text = "Enter task hours";
            // 
            // labelTaskStartDate
            // 
            this.labelTaskStartDate.AutoSize = true;
            this.labelTaskStartDate.Location = new System.Drawing.Point(29, 92);
            this.labelTaskStartDate.Name = "labelTaskStartDate";
            this.labelTaskStartDate.Size = new System.Drawing.Size(102, 13);
            this.labelTaskStartDate.TabIndex = 3;
            this.labelTaskStartDate.Text = "Enter task start date";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(29, 61);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(109, 13);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = "Enter task description";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(29, 32);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(84, 13);
            this.labelTaskName.TabIndex = 1;
            this.labelTaskName.Text = "Enter task name";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(233, 245);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(713, 13);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(75, 23);
            this.txtBack.TabIndex = 1;
            this.txtBack.Text = "Back";
            this.txtBack.UseVisualStyleBackColor = true;
            this.txtBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // labelTaskId
            // 
            this.labelTaskId.AutoSize = true;
            this.labelTaskId.Location = new System.Drawing.Point(131, 49);
            this.labelTaskId.Name = "labelTaskId";
            this.labelTaskId.Size = new System.Drawing.Size(42, 13);
            this.labelTaskId.TabIndex = 2;
            this.labelTaskId.Text = "Task id";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(238, 42);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(100, 20);
            this.txtTaskId.TabIndex = 3;
            // 
            // frmTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.labelTaskId);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.grpTask);
            this.Name = "frmTaskAdd";
            this.Text = "frmTaskAdd";
            this.grpTask.ResumeLayout(false);
            this.grpTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button txtBack;
        private System.Windows.Forms.Label labelTaskId;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label labelTaskStartDate;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelTaskPriority;
        private System.Windows.Forms.Label labelTaskHours;
    }
}