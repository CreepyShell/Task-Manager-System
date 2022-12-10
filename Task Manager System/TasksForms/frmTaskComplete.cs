using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskComplete : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmTaskComplete(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            Task task = db.Tasks.FirstOrDefault(t => t.Id == txtTaskId.Text);
            if (task == null)
            {
                MessageBox.Show("Task was not found");
                return;
            }

            if (task.StartDate.AddHours(task.Hours) < DateTime.Now)
            {
                MessageBox.Show("Deadline is expired");
                return;
            }

            if (task.Status == Status.Finished)
            {
                MessageBox.Show("Task is already been finished");
                return;
            }
            db.Tasks.Remove(task);
            task.Status = Status.Finished;
            db.Tasks.Add(task);
            MessageBox.Show("Task was finished");
        }
    }
}
