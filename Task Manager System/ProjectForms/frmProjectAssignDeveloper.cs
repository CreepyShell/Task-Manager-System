using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectAssignDeveloper : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmProjectAssignDeveloper(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void frmProjectAssignDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void dtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Project project = db.Projects.FirstOrDefault(x => x.Id == txtProjId.Text);
            if (project == null)
            {
                MessageBox.Show("Project with this id was not found");
                return;
            }

            if (project.Status == Status.Finished)
            {
                MessageBox.Show("Project is finished");
                return;
            }

            Developer developer = db.Developers.FirstOrDefault(d => d.Id == txtDevId.Text);
            if (developer == null)
            {
                MessageBox.Show("Developer with this id was not found");
                return;
            }

            if (developer.Project != null)
            {
                MessageBox.Show("Chosen developer has already been assigned to the project");
                return;
            }

            if (db.Tasks.Any(t => t.Developer.Id == developer.Id))
            {
                MessageBox.Show("Chosen developer has tasks so he or she can not be assigned to the proejct");
                return;
            }

            db.Developers.Remove(developer);
            developer.Project = project;
            db.Developers.Add(developer);
        }
    }
}
