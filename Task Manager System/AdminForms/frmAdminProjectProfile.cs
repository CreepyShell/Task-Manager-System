using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminProjectProfile : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IProjectService _projectService;
        private readonly ITaskService _taskService;
        private readonly IDevService _devService;
        public frmAdminProjectProfile(frmMenu menu, IProjectService projectService, ITaskService taskService, IDevService devService)
        {
            _projectService = projectService;
            _taskService = taskService;
            _devService = devService;
            InitializeComponent();
            MainMenu = menu;
        }

        private async void btnFindProject_Click(object sender, EventArgs e)
        {
            if (cboProject.Items.Count == 0)
            {
                MessageBox.Show("No projects available");
                return;
            }
            Project project = await _projectService.GetById(int.Parse(new string(cboProject.Text.TakeWhile(c => c != ':').ToArray())));
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            List<Task> tasks = await _taskService.GetAllProjectTasks(project.Id);
            txtTasks.Text = tasks.Count.ToString();
            txtHours.Text = tasks.Select(t => t.Hours).Sum().ToString();
            txtDuration.Text = (project.EndDate - project.StartDate).ToString();
            txtCost.Text = project.ExpectedCost.ToString();
            Developer[] developers = (await _devService.GetAll()).Where(d => d.Project?.Id == project.Id).ToArray();
            cboDevelopers.Items.Clear();
            dgvDevs.Rows.Clear();
            foreach (Developer developer in developers)
            {
                cboDevelopers.Items.Add(developer.FirstName + " " + developer.LastName);
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() {Value = developer.FirstName });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = developer.LastName });
                dgvDevs.Rows.Add(row);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void frmAdminProjectProfile_Load(object sender, EventArgs e)
        {
            cboDevelopers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Project project in await _projectService.GetAll())
                cboProject.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}");
            if (cboProject.Items.Count > 0)
                cboProject.SelectedItem = cboProject.Items[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
