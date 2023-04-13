using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminProjectRevenue : Form
    {
        private readonly frmMenu frmMenu;
        private readonly TasksDb db;
        public frmAdminProjectRevenue(frmMenu frmMenu)
        {
            db = TasksDb.GetTasksDb();
            this.frmMenu = frmMenu;
            InitializeComponent();
        }

        private void frmAdminProjectRevenue_Load(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = new DateTime(1970, 1, 1);
            dtpEndDate.MinDate = dtpStartDate.MinDate.AddDays(1);
            cmbProjects.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu.Show();

        }

        private void btnFindProject_Click(object sender, EventArgs e)
        {
            Project[] projects = db.Projects.Where(p => p.Status == Status.Finished && p.EndDate < dtpEndDate.Value).ToArray();
            decimal revenue = 0;
            if (projects.Length == 0)
            {
                MessageBox.Show("No projects found");
                return;
            }
            foreach (Project project in projects)
            {
                cmbProjects.Items.Add($"{project.Name}--{project.ExpectedCost}$");
                if (project.StartDate > dtpStartDate.Value)
                    revenue += project.ExpectedCost;
                else
                {
                    TimeSpan projDuration = project.EndDate - project.StartDate;
                    TimeSpan projDurationInChosenPeriod = dtpStartDate.Value - project.StartDate;
                    revenue += projDurationInChosenPeriod.Days / projDuration.Days * project.ExpectedCost;
                }
            }
            TimeSpan duration = dtpEndDate.Value - dtpStartDate.Value;
            txtMonthRevenue.Text = (revenue * 30 / duration.Days).ToString();

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }
    }
}
