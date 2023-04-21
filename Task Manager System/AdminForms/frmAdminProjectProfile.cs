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
        public frmAdminProjectProfile(frmMenu menu, IProjectService projectService, ITaskService taskService)
        {
            _projectService = projectService;
            _taskService = taskService;
            InitializeComponent();
            MainMenu = menu;
        }

        private async void btnFindProject_Click(object sender, EventArgs e)
        {
            //
            if (cboProject.Items.Count == 0)
            {
                MessageBox.Show("No projects available");
                return;
            }
            Project project = await _projectService.GetProjectWithDevelopers(int.Parse(new string(cboProject.Text.TakeWhile(c => c != ':').ToArray())));
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            List<Task> tasks = await _taskService.GetAllProjectTasks(project.Id);
            txtTasks.Text = tasks.Count.ToString();
            txtHours.Text = tasks.Select(t => t.Hours).Sum().ToString();//find the sum of hours needed to complete all tasks assigned to a project
            txtDuration.Text = (project.EndDate - project.StartDate).TotalDays.ToString();//find the project duration in days
            txtCost.Text = project.ExpectedCost.ToString();
            txtStatus.Text = project.Status.ToString();

            Developer[] developers = project.Developers.ToArray();
            dgvDevs.Rows.Clear();
            foreach (Developer developer in developers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() {Value = developer.FirstName });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = developer.LastName });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = developer.Specialization });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = developer.Age });
                dgvDevs.Rows.Add(row);
            }
            dgvTasks.Rows.Clear();
            foreach (Task task in tasks)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.Name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.Description });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.StartDate.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.Hours });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.Status });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = task.Priority });
                dgvTasks.Rows.Add(row);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }
        private async void frmAdminProjectProfile_Load(object sender, EventArgs e)
        {
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Project project in await _projectService.GetAll())
                cboProject.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}");
            if (cboProject.Items.Count > 0)
                cboProject.SelectedItem = cboProject.Items[0];
        }
    }
}
