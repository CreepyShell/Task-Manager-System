using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Models;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskUpdate : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        private Task task;
        public frmTaskUpdate(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void frmUpdateTask_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void dtnTaskFind_Click(object sender, EventArgs e)
        {
            task = db.Tasks.FirstOrDefault(t => t.Id == txtTaskId.Text);
            if (task == null)
            {
                MessageBox.Show("Task was not found");
                return;
            }

            txtTaskName.Text = task.Name;
            txtTaskDescription.Text = task.Description;
            txtTaskHours.Text = task.Hours.ToString();
            txtTaskStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTaskStatus.Text = task.Status.ToString();
            txtTaskPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTaskPriority.Text = task.Priority.ToString();

            this.grpTask.Visible = true;
            this.btnSaveTaskDetails.Visible = true;
        }

        private void btnSaveTaskDetails_Click(object sender, EventArgs e)
        {
            int hours = 0;
            if (txtTaskName.Text.Length > 20 || txtTaskName.Text.Length < 5)
            {
                MessageBox.Show("Name must be greater than 5 symbols and less than 20 symbols");
                return;
            }
            if (txtTaskDescription.Text.Length > 200)
            {
                MessageBox.Show("Description must be less than 200 symblos");
                return;
            }

            if (task.Status == Status.Extended)
            {
                txtTaskStatus.Enabled = false;
            }

            try
            {
                hours = int.Parse(txtTaskHours.Text);
                if (hours < 0 || hours > 72)
                {
                    MessageBox.Show("Task hours mush be greater than 0 and less than 72");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hours format");
                return;
            }
            db.Tasks.Remove(task);
            task.Name = txtTaskName.Text;
            task.Description = txtTaskDescription.Text;
            task.Hours = hours;
            task.Priority = (Priority)Enum.Parse(typeof(Priority), txtTaskPriority.Text);
            task.Status = (Status)Enum.Parse(typeof(Status), txtTaskStatus.Text);
            db.Tasks.Add(task);
            MessageBox.Show("Task updated");

            this.grpTask.Visible = false;
            this.btnSaveTaskDetails.Visible = false;
        }
    }
}
