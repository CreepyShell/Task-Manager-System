using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminProjectProfile : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IProjectService _projectService;
        private readonly TasksDb db;
        public frmAdminProjectProfile(frmMenu menu, IProjectService projectService)
        {
            _projectService = projectService;
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void btnFindProject_Click(object sender, EventArgs e)
        {
            Project project = db.Projects.FirstOrDefault(p => p.Id.ToString() == new string(cboProject.Text.TakeWhile(c => c != ':').ToArray()));
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            Task[] tasks = db.Tasks.Where(t => t.Project.Id == project.Id).ToArray();
            txtTasks.Text = tasks.Length.ToString();
            txtHours.Text = tasks.Select(t => t.Hours).Sum().ToString();
            txtDuration.Text = (project.EndDate - project.StartDate).ToString();
            txtCost.Text = project.ExpectedCost.ToString();
            Developer[] developers = db.Developers.Where(d => d.Project?.Id == project.Id).ToArray();
            foreach (Developer developer in developers)
                txtDevelopers.Items.Add(developer.FirstName + " " + developer.LastName);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void frmAdminProjectProfile_Load(object sender, EventArgs e)
        {
            txtDevelopers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Project project in await _projectService.GetAll())
            {
                cboProject.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}");
            }
        }
    }
}
