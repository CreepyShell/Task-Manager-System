using System;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectUpdate : Form
    {
        private IProjectService projectService;
        private Project project;
        private frmMenu MainMenu;
        public frmProjectUpdate()
        {
            InitializeComponent();
        }

        public frmProjectUpdate(frmMenu menu, IProjectService projectService)
        {
            MainMenu = menu;
            this.projectService = projectService;
            InitializeComponent();
        }

        private void frmProjectUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainMenu != null)
                MainMenu.Show();
        }

        private void btnFindProj_Click(object sender, EventArgs e)
        {
            this.grpProject.Visible = true;
            //project = await projectService.GetById(project.Id);
        }

        private void btnSaveProj_Click(object sender, EventArgs e)
        {
            this.grpProject.Visible = false;
        }
    }
}
