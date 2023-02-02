using Castle.Windsor;
using System;
using System.Windows.Forms;
using Task_Manager_System.AdminForms;
using Task_Manager_System.ProjectForms;
using Task_Manager_System.Services;
using Task_Manager_System.TasksForms;
using TMS_BLL.Interfaces;

namespace Task_Manager_System
{
    public partial class frmMenu : Form
    {
        private WindsorContainer container;
        
        public frmMenu()
        {
            InitializeComponent();
            container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<IProjectService>().ImplementedBy<ProjectService>());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectAdd projectAdd = new frmProjectAdd(this, container.Resolve<IProjectService>());
            projectAdd.Show();
        }

        private void updateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectUpdate projectAdd = new frmProjectUpdate(this);
            projectAdd.Show();
        }

        private void assignDeveloperToAProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectAssignDeveloper projectAssignDeveloper = new frmProjectAssignDeveloper(this);
            projectAssignDeveloper.Show();
        }

        private void completeAProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectComplete projectComplete = new frmProjectComplete(this);
            projectComplete.Show();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskAdd taskAdd = new frmTaskAdd(this);
            taskAdd.Show();
        }

        private void updateTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskUpdate taskUpdate = new frmTaskUpdate(this);
            taskUpdate.Show();
        }

        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskRemove taskRemove = new frmTaskRemove(this);
            taskRemove.Show();
        }

        private void assignDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskAssignDeveloper taskAssignDeveloper = new frmTaskAssignDeveloper(this);
            taskAssignDeveloper.Show();
        }

        private void removeDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskRemoveDeveloper TaskRemoveDeveloper = new frmTaskRemoveDeveloper(this);
            TaskRemoveDeveloper.Show();
        }

        private void completeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskComplete taskComplete = new frmTaskComplete(this);
            taskComplete.Show();
        }

        private void showProjectProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProjectProfile frmAdminProjectProfile = new frmAdminProjectProfile(this);
            frmAdminProjectProfile.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDeveloperProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDeveloperProfile frmAdminDeveloperProfile = new frmAdminDeveloperProfile(this); 
            frmAdminDeveloperProfile.Show();
        }

        private void showMonthRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProjectRevenue frmAdminProjectRevenue = new frmAdminProjectRevenue(this);
            frmAdminProjectRevenue.Show();
        }
    }
}
