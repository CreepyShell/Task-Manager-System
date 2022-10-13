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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.Show();
            this.Hide();
        }

        private void Developers_Click(object sender, EventArgs e)
        {
            DevelopersForm developersForm = new DevelopersForm();
            developersForm.Show();
            this.Hide();
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            ProjectsForm projectsForm = new ProjectsForm();
            projectsForm.Show();
            this.Hide();
        }
    }
}
