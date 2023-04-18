using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectAssignDeveloper : Form
    {
        private readonly IProjectService _projectService;
        private readonly IDevService _devService;
        private readonly frmMenu MainMenu;
        public frmProjectAssignDeveloper(frmMenu menu, IProjectService projectService, IDevService devService)
        {
            _projectService = projectService;
            _devService = devService;
            InitializeComponent();
            MainMenu = menu;
        }

        private async void frmProjectAssignDeveloper_Load(object sender, EventArgs e)
        {
            cmbDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer developer in await this._devService.GetAll())
                cmbDev.Items.Add($"{developer.Id}: {developer.FirstName} {developer.LastName}, {developer.Age} years. {developer.Specialization}" +
                    $"    Developer: {developer.Project?.Id}");
            if (cmbDev.Items.Count > 0)
                cmbDev.SelectedItem = cmbDev.Items[0];

            cmbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Project project in await _projectService.GetAll())
                cmbProject.Items.Add($"{project.Id}: {project.Name}  Deadline: {project.EndDate:dd-MM-yyyy}   Status:{project.Status} ");
            if (cmbProject.Items.Count > 0)
                cmbProject.SelectedItem = cmbProject.Items[0];
        }

        private void dtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbDev.Items.Count == 0 || cmbProject.Items.Count == 0)
            {
                MessageBox.Show("No developers or tasks available");
                return;
            }
            try
            {
                int projectId = int.Parse(new string(cmbProject.Text.TakeWhile(c => c != ':').ToArray()));

                int developerId = int.Parse(new string(cmbDev.Text.TakeWhile(c => c != ':').ToArray()));

                if (await _projectService.AssignDeveloperToProject(projectId, developerId))
                {
                    MessageBox.Show("Developer was assigned successfully");
                    return;
                }
                MessageBox.Show("Developer is already assigned to a project or has some tasks to do");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Not found: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid data:" + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Smt went wrong");
            }
        }
    }
}
