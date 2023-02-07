using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskAssignDeveloper : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmTaskAssignDeveloper(frmMenu menu)
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

        private void btnTaskAssignDeveloper_Click(object sender, EventArgs e)
        {
            Developer developer = db.Developers.FirstOrDefault(d => d.Id.ToString() == txtDevId.Text);
            if(developer == null)
            {
                MessageBox.Show("Developer was not found");
                return;
            }

            Task task = db.Tasks.FirstOrDefault(d=>d.Id.ToString() == txtTaskId.Text);
            if(task == null)
            {
                MessageBox.Show("Task was not found");
                return;
            }

            if(task.Status == Status.Finished)
            {
                MessageBox.Show("Task is finished");
                return;
            }

            if (task.Developer != null)
            {
                MessageBox.Show("Task is already been assigned to a developer");
                return;
            }

            if (developer.Project != null)
            {
                if (developer.Project.Id != task.Project.Id)
                {
                    MessageBox.Show("Developer is assigned to the other project");
                    return;
                }
            }
            db.Tasks.Remove(task);
            task.Developer = developer;
            db.Tasks.Add(task);
            MessageBox.Show("Developer was assigned");
        }
    }
}
