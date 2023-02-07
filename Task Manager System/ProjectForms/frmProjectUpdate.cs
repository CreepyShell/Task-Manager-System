using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectUpdate : Form
    {
        private Project project;
        private TasksDb db;
        private frmMenu MainMenu;
        public frmProjectUpdate()
        {
            InitializeComponent();
            db = TasksDb.GetTasksDb();
        }

        public frmProjectUpdate(frmMenu menu)
        {
            MainMenu = menu;
            InitializeComponent();
            db = TasksDb.GetTasksDb();
        }

        private void frmProjectUpdate_Load(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = DateTime.Today;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainMenu != null)
                MainMenu.Show();
        }

        private void btnFindProj_Click(object sender, EventArgs e)
        {
            this.project = db.Projects.FirstOrDefault(p => p.Id.ToString() == txtProjId.Text);
            if (project == null)
            {
                MessageBox.Show("Project with chosen id was not found");
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
            this.txtStatus.Text = project.Status.ToString();
        }

        private void btnSaveProj_Click(object sender, EventArgs e)
        {

            if (project.Status == Status.Extended)
                txtStatus.Enabled = false;


            if (txtDescription.Text.Length > 200)
            {
                MessageBox.Show("Description length must be less than 200 symbols");
                return;
            }

            if (txtName.Text.Length > 30 || txtName.Text.Length < 5)
            {
                MessageBox.Show("Name length must be less than 30 symbols and greater than 5");
                return;
            }

            if (txtStatus.Text != "Created" && txtStatus.Text != "Started" && txtStatus.Text != "Extended" && txtStatus.Text != "Finished")
            {
                MessageBox.Show("Invalid status");
                return;
            }
            try
            {
                if (double.Parse(txtExpectedCost.Text) < 0)
                {
                    MessageBox.Show("Expected cost must be greater than zero");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Excepted cost must be numeric");
                return;
            }
            int projId = project.Id;
            DateTime startDate = project.StartDate;
            this.db.Projects.Remove(project);

            project.Description = txtDescription.Text;
            project.Id = projId;
            project.StartDate = startDate;
            project.Name = txtName.Text;
            project.ExpectedCost = Convert.ToDouble(txtExpectedCost.Text);

            project.Status = (Status)Enum.Parse(typeof(Status), txtStatus.Text);
            this.db.Projects.Add(project);

            this.grpProject.Visible = false;
        }
    }
}
