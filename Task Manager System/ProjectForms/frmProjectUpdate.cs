using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectUpdate : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IProjectService projectService;

        private Project project;
        public frmProjectUpdate()
        {
            InitializeComponent();
        }

        public frmProjectUpdate(frmMenu menu, IProjectService _projectService)
        {
            MainMenu = menu;
            InitializeComponent();
            projectService = _projectService;
        }

        private async void frmProjectUpdate_Load(object sender, EventArgs e)
        {
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.SelectedItem = cboStatus.Items[0];
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            Project[] projects = (await projectService.GetUnfinishedProject()).ToArray();
            foreach (Project project in projects)
            {
                cboProject.Items.Add($"{project.Id}: {project.Name} {project.EndDate:dd-MM-yyyy}  Status:{project.Status}");
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
            this.cboStatus.Text = project.Status.ToString();
        }

        private async void btnSaveProj_Click(object sender, EventArgs e)
        {

            if (await projectService.GetByName(txtName.Text) != null)
            {
                MessageBox.Show("There is a project with this name, try another name");
                return;
            }
            if (project.Status == Status.Extended)
            {
                cboStatus.Enabled = false;
                cboStatus.Text = project.Status.ToString();
            }

            if (cboStatus.Text != "Created" && cboStatus.Text != "Started" && cboStatus.Text != "Extended" && cboStatus.Text != "Finished")
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
                project.Status = (Status)Enum.Parse(typeof(Status), cboStatus.Text);
                project.ExpectedCost = Convert.ToDecimal(txtExpectedCost.Text);
                await this.projectService.UpdateProject(project.Id, project);
            }
            catch (FormatException)
            {
                MessageBox.Show("Excepted cost must be numeric");
                return;
            }

            
           

            this.grpProject.Visible = false;
        }
    }
}
