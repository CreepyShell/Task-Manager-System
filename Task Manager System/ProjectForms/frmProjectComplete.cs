using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectComplete : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmProjectComplete(frmMenu menu)
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

        private void btnProjectComplete_Click(object sender, EventArgs e)
        {
            Project project = db.Projects.FirstOrDefault(p => p.Id.ToString() == txtProjId.Text);
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }

            if (db.Tasks.Any(t => t.Project.Id == project.Id && t.Status != Status.Finished))
            {
                MessageBox.Show("Project has unfinished tasks");
                return;
            }

            if (project.EndDate < DateTime.Now)
            {
                MessageBox.Show("Deadline is expired, extend it");
                return;
            }

            db.Projects.Add(project);
            project.Status = Status.Finished;
            project.EndDate = DateTime.Now;
            db.Projects.Add(project);

            Developer[] developers = db.Developers.Where(d => d.Project != null).ToArray();
            foreach (Developer developer in developers)
            {
                db.Developers.Remove(developer);
                developer.Project = null;
                db.Developers.Add(developer);
            }    

        }
    }
}
