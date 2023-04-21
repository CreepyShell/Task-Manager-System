using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Windows.Forms;
using Task_Manager_System.AdminForms;
using Task_Manager_System.Interfaces;
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
            container.Register(Component.For<IProjectService>().ImplementedBy<ProjectService>());
            container.Register(Component.For<ITaskService>().ImplementedBy<TaskService>());
            container.Register(Component.For<IDevService>().ImplementedBy<DevService>());
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
            frmProjectUpdate projectAdd = new frmProjectUpdate(this, container.Resolve<IProjectService>());
            projectAdd.Show();
        }

        private void assignDeveloperToAProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectAssignDeveloper projectAssignDeveloper = new frmProjectAssignDeveloper(this, container.Resolve<IProjectService>(), container.Resolve<IDevService>());
            projectAssignDeveloper.Show();
        }

        private void completeAProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectComplete projectComplete = new frmProjectComplete(this, container.Resolve<IProjectService>());
            projectComplete.Show();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskAdd taskAdd = new frmTaskAdd(this, container.Resolve<ITaskService>(),
                container.Resolve<IProjectService>(),
                container.Resolve<IDevService>());
            taskAdd.Show();
        }

        private void updateTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskUpdate taskUpdate = new frmTaskUpdate(this, container.Resolve<ITaskService>());
            taskUpdate.Show();
        }

        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskRemove taskRemove = new frmTaskRemove(this, container.Resolve<ITaskService>());
            taskRemove.Show();
        }

        private void assignDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskAssignDeveloper taskAssignDeveloper = new frmTaskAssignDeveloper(this, container.Resolve<IDevService>(), container.Resolve<ITaskService>());
            taskAssignDeveloper.Show();
        }

        private void removeDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskRemoveDeveloper TaskRemoveDeveloper = new frmTaskRemoveDeveloper(this, container.Resolve<ITaskService>(), container.Resolve<IDevService>());
            TaskRemoveDeveloper.Show();
        }

        private void completeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaskComplete taskComplete = new frmTaskComplete(this, container.Resolve<ITaskService>());
            taskComplete.Show();
        }

        private void showProjectProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProjectProfile frmAdminProjectProfile = new frmAdminProjectProfile(this, container.Resolve<IProjectService>(), container.Resolve<ITaskService>());
            frmAdminProjectProfile.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDeveloperProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDeveloperProfile frmAdminDeveloperProfile = new frmAdminDeveloperProfile(this, container.Resolve<IDevService>(), container.Resolve<ITaskService>());
            frmAdminDeveloperProfile.Show();
        }

        private void showMonthRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminProjectRevenue frmAdminProjectRevenue = new frmAdminProjectRevenue(this, container.Resolve<IProjectService>());
            frmAdminProjectRevenue.Show();
        }
    }
}
