using FluentValidation;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectAdd : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IProjectService _projectService;
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        public frmProjectAdd(frmMenu menu, IProjectService projectService)
        {
            _projectService = projectService;
            MainMenu = menu;
            InitializeComponent();
        }

        private void frmProjectAdd_Load(object sender, EventArgs e)
        {
            txtProjId.Text = Project.GetNextProjId().ToString();
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
                project.Id = int.Parse(txtProjId.Text);
                project.Name = txtName.Text;
                project.Description = txtDescription.Text;
                project.StartDate = dtpDateStart.Value;
                project.EndDate = dtpDateEnd.Value;
                project.ExpectedCost = Convert.ToDecimal(txtExpectedCost.Text);
                project.Status = Status.Started;

                await _projectService.AddProject(project);
                txtProjId.Text = (project.Id + 1).ToString();
                MessageBox.Show("Project is successfully added");
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("Invalid project: " + ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Expected cost must be numeric");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Smt went wrong:" + ex.Message);
            }

        }

        private void grpProject_Enter(object sender, EventArgs e)
        {

        }
    }
}
