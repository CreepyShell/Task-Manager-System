using Castle.Windsor;
using System;
using System.Windows.Forms;
using Task_Manager_System.ProjectForms;
using Task_Manager_System.Services;
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
            frmProjectAdd projectAdd = new frmProjectAdd(this, null);
            projectAdd.Show();
        }

        private void updateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjectUpdate projectAdd = new frmProjectUpdate(this, null);
            projectAdd.Show();
        }
    }
}
