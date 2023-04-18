using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminDeveloperProfile : Form
    {
        private readonly IDevService _devService;
        private readonly ITaskService _taskService;
        private readonly IProjectService _projectService;
        private readonly frmMenu MainMenu;
        public frmAdminDeveloperProfile(frmMenu menu, IDevService devService, ITaskService taskService, IProjectService projectService)
        {
            _devService = devService;
            _taskService = taskService;
            _projectService = projectService;
            InitializeComponent();
            MainMenu = menu;
        }

        private async void btnFindDeveloper_Click(object sender, EventArgs e)
        {
            txtProjectInfo.Clear();
            txtTasksInfo.Items.Clear();
            if (cboDev.Items.Count == 0)
            {
                MessageBox.Show("No developers available now");
                return;
            }
            int devId = int.Parse(new string(cboDev.Text.TakeWhile(c => c != ':').ToArray()));
            Developer developer = await _devService.GetDeveloperById(devId);
            if (developer == null)
            {
                MessageBox.Show("Developer was not found");
                return;
            }
            List<Task> tasks = await _taskService.GetDeveloperTasks(devId);
            foreach (Task task in tasks)
                txtTasksInfo.Items.Add($"{task.Name}--{task.Hours}--{task.Status}--{task.Project?.Id}");
            if(developer.Project != null)
            {
                Project project = await _projectService.GetById(developer.Project.Id);
                txtProjectInfo.Text = $"{project.Name}--{project.Status}--{project.StartDate}--{project.EndDate}";
                return;
            }
            txtProjectInfo.Text = "Null";
        }

        private async void frmAdminDeveloperProfile_Load(object sender, EventArgs e)
        {
            txtTasksInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer developer in await _devService.GetAll())
                cboDev.Items.Add($"{developer.Id}: {developer.FirstName} {developer.LastName}, {developer.Age} years. {developer.Specialization}");

            if (cboDev.Items.Count > 0)
                cboDev.SelectedItem = cboDev.Items[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show(); 
        }
    }
}
