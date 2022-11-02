using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_System
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTasks tasksForm = new frmTasks();
            tasksForm.Show();
            this.Hide();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevelopers developersForm = new frmDevelopers();
            developersForm.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjects projectsForm = new frmProjects();
            projectsForm.Show();
            this.Hide();
        }
    }
}
