using FluentValidation;
using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using Task_Manager_System.Models;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskAdd : Form
    {
        private readonly frmMenu MainMenu;
        private readonly ITaskService taskService;
        private readonly IProjectService projectService;
        private readonly IDevService devService;

        public frmTaskAdd(frmMenu menu, ITaskService taskService, IProjectService projectService, IDevService devService)
        {
            InitializeComponent();
            MainMenu = menu;
            this.taskService = taskService;
            this.projectService = projectService;
            this.devService = devService;
        }


        private void txtBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnAddTask_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Id = int.Parse(txtTaskId.Text);
            task.Name = txtName.Text;
            task.Description = txtDescription.Text;
            task.StartDate = dtpStartTime.Value;
            if (cboProjects.Items.Count == 0)
            {
                MessageBox.Show("No project available");
                return;
            }

            try
            {
                if(await taskService.GetByName(txtName.Text) != null)
                {
                    MessageBox.Show("There is a task with this name, use another name");
                    return;
                }
                Project project = await projectService.GetById(int.Parse(new string(cboProjects.Text.TakeWhile(c => c != ':').ToArray())));
                if (project == null)
                {
                    MessageBox.Show("Project was not found");
                    return;
                }

                Developer developer = null;
                if (cboDev.SelectedItem != null)
                    developer = await devService.GetDeveloperById(int.Parse(new string(cboDev.Text.TakeWhile(c => c != ':').ToArray())));

                task.Project = project;
                task.Developer = developer;

                task.Priority = (Priority)Enum.Parse(typeof(Priority), cmbPriority.Text);
                task.Status = (Status)Enum.Parse(typeof(Status), cboStatus.Text);
                int hours = int.Parse(txtTaskHours.Text);
                task.Hours = hours;
                await taskService.AddTaskToProject(task);
                MessageBox.Show("Task added");
                txtTaskId.Text = Task.GetNextTaskId().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hours format");
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Data not found: " + ex.Message);
                return;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("Data invalid: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Smt went wrong: " + ex.Message);
                return;
            }
        }

        private async void frmTaskAdd_Load(object sender, EventArgs e)
        {
            dtpStartTime.MinDate = DateTime.Now;
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.SelectedItem = cmbPriority.Items[0].ToString();

            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.SelectedItem = cboStatus.Items[0].ToString();

            txtTaskId.Text = Task.GetNextTaskId().ToString();
            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer dev in await this.devService.GetAll())
                cboDev.Items.Add($"{dev.Id}: {dev.FirstName} {dev.LastName} {dev.Specialization}");

            cboProjects.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Project project in await this.projectService.GetAll())
                cboProjects.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}");

            if (cboProjects.Items.Count > 0)
                cboProjects.SelectedItem = cboProjects.Items[0];
        }

        private void cboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpTask_Enter(object sender, EventArgs e)
        {

        }
    }
}
