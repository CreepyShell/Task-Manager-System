using System;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectAdd : Form
    {
        private IProjectService projectService;
        private frmMenu MainMenu;
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        public frmProjectAdd(frmMenu menu, IProjectService projectService)
        {
            MainMenu = menu;
            this.projectService = projectService;
            InitializeComponent();
        }

        private void frmProjectAdd_Load(object sender, EventArgs e)
        {
            txtProjId.Text = Guid.NewGuid().ToString();
            dtpDateStart.MinDate = DateTime.Today;
            dtpDateEnd.MinDate = DateTime.Today.AddDays(1);
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtpDateEnd.MinDate = dtpDateStart.Value.AddDays(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainMenu != null)
                MainMenu.Show();
        }

        private async void btnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = new Project();
                project.Name = txtName.Text;
                project.Description = txtDescription.Text;
                project.StartDate = dtpDateStart.Value;
                project.EndDate = dtpDateEnd.Value;
                project.ExpectedCost = Convert.ToDouble(txtExpectedCost.Text);
                bool res = await projectService.AddProject(project);
                MessageBox.Show("Project is successfully added");
            }
            catch (FormatException)
            {
                MessageBox.Show("Expected cost must be numeric");
            }
        }

        private void grpProject_Enter(object sender, EventArgs e)
        {

        }
    }
}
