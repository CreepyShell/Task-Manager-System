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
            if (txtName.Text.Length > 20 || txtName.Text.Length < 5)
            {
                MessageBox.Show("Name must be greater than 5 symbols and less than 20 symbols");
                return;
            }
            task.Name = txtName.Text;

            if (txtDescription.Text.Length > 200)
            {
                MessageBox.Show("Description must be less than 200 symblos");
                return;
            }
            task.Description = txtDescription.Text;
            task.StartDate = dtpStartTime.Value;
            try
            {
                int hours = int.Parse(txtTaskHours.Text);
                if (hours < 0 || hours > 72)
                {
                    MessageBox.Show("Task hours mush be greater than 0 and less than 72");
                    return;
                }
                task.Hours = hours;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hours format");
                return;
            }
            Project project = await projectService.GetById(int.Parse(txtProjId.Text));
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            string text = new string(cboDev.Text.TakeWhile(c => c != ':').ToArray());
            Developer developer = await devService.GetDeveloperById(int.Parse(cboDev.Text.TakeWhile(c => c == ':').ToString()));
            if (developer == null)
            {
                MessageBox.Show("Developer was not found");
                return;
            }
            task.Priority = (Priority)Enum.Parse(typeof(Priority), cmbPriority.Text);
            task.Status = (Status)Enum.Parse(typeof(Status), cmbStatus.Text);

            //change form text to combobox to let a user choose a project

            task.Project = project;
            task.Developer = developer;
            await taskService.AddTaskToProject(task);
            MessageBox.Show("Task added");
            txtTaskId.Text = Task.GetNextTaskId().ToString();
        }

        private async void frmTaskAdd_Load(object sender, EventArgs e)
        {
            dtpStartTime.MinDate = DateTime.Now;
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Text = cmbPriority.Items[0].ToString();
            txtTaskId.Text = Task.GetNextTaskId().ToString();
            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer dev in await this.devService.GetAll())
            {
                cboDev.Items.Add($"{dev.Id}: {dev.FirstName} {dev.LastName} {dev.Specialization}");
            }
        }

        private void cboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
