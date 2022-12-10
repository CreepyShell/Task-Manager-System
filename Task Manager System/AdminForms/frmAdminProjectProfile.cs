using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminProjectProfile : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmAdminProjectProfile(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void btnFindProject_Click(object sender, EventArgs e)
        {
            Project project = db.Projects.FirstOrDefault(p => p.Id == txtProjId.Text);
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            Task[] tasks = db.Tasks.Where(t => t.Project.Id == project.Id).ToArray();
            txtTasks.Text = tasks.Length.ToString();
            txtHours.Text = tasks.Select(t => t.Hours).Sum().ToString();
            txtDuration.Text = (project.EndDate - project.StartDate).ToString();
            txtCost.Text = project.ExpectedCost.ToString();
            Developer[] developers = db.Developers.Where(d => d.Project?.Id == project.Id).ToArray();
            foreach (Developer developer in developers)
                txtDevelopers.Items.Add(developer.FirstName + " " + developer.LastName);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void frmAdminProjectProfile_Load(object sender, EventArgs e)
        {
            txtDevelopers.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
