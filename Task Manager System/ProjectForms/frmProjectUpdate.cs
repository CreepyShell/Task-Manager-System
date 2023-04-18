using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectUpdate : Form
    {
        private readonly TasksDb db;
        private readonly frmMenu MainMenu;
        private readonly IProjectService projectService;

        private Project project;
        public frmProjectUpdate()
        {
            InitializeComponent();
            db = TasksDb.GetTasksDb();
        }

        public frmProjectUpdate(frmMenu menu, IProjectService _projectService)
        {
            MainMenu = menu;
            InitializeComponent();
            db = TasksDb.GetTasksDb();
            projectService = _projectService;
        }

        private async void frmProjectUpdate_Load(object sender, EventArgs e)
        {
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            Project[] projects = (await projectService.GetAll()).ToArray();
            foreach (Project project in projects)
            {
                cboProject.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}");
            }
            dtpEndDate.MinDate = DateTime.Today;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainMenu != null)
                MainMenu.Show();
        }

        private async void btnFindProj_Click(object sender, EventArgs e)
        {
            bool parse = int.TryParse(new string(cboProject.Text.TakeWhile(c => c != ':').ToArray()), out int res);
            if (!parse)
            {
                MessageBox.Show("Invalid id");
                this.grpProject.Visible = false;
                return;
            }
            this.project = await this.projectService.GetById(res);
            if (project == null)
            {
                MessageBox.Show("Project with chosen id was not found");
                this.grpProject.Visible = false;
                return;
            }

            if (project.Status == Status.Finished)
            {
                MessageBox.Show("Project is finished");
                return;
            }

            this.grpProject.Visible = true;
            this.txtDescription.Text = project.Description;
            this.txtName.Text = project.Name;
            this.txtExpectedCost.Text = project.ExpectedCost.ToString();
            this.txtStatus.Text = project.Status.ToString();
        }

        private async void btnSaveProj_Click(object sender, EventArgs e)
        {

            if (project.Status == Status.Extended)
            {
                txtStatus.Enabled = false;
                txtStatus.Text = project.Status.ToString();
            }

            if (txtStatus.Text != "Created" && txtStatus.Text != "Started" && txtStatus.Text != "Extended" && txtStatus.Text != "Finished")
            {
                MessageBox.Show("Invalid status");
                return;
            }
            try
            {
                int projId = project.Id;
                project.Description = txtDescription.Text;
                project.Id = projId;
                project.EndDate = dtpEndDate.Value;
                project.Name = txtName.Text;
                project.Status = (Status)Enum.Parse(typeof(Status), txtStatus.Text);
                project.ExpectedCost = Convert.ToDecimal(txtExpectedCost.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Excepted cost must be numeric");
                return;
            }

            
            await this.projectService.UpdateProject(project.Id, project);

            this.grpProject.Visible = false;
        }
    }
}
