using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminProjectRevenue : Form
    {
        private readonly frmMenu frmMenu;
        private readonly IProjectService _projectService;
        public frmAdminProjectRevenue(frmMenu frmMenu, IProjectService projectService)
        {
            _projectService = projectService;
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

        private async void btnFindProject_Click(object sender, EventArgs e)
        {
            Project[] projects = (await _projectService.GetAll()).Where(p => p.Status == Status.Finished && p.EndDate < dtpEndDate.Value)
                .ToArray();//find all projects that was finished before the seleted end date

            decimal revenue = 0;//total revenue
            if (projects.Length == 0)
            {
                MessageBox.Show("No projects found");
                return;
            }
            foreach (Project project in projects)
            {
                cmbProjects.Items.Add($"Name:{project.Name}    Total cost: {project.ExpectedCost}$   StartDate: {project.StartDate}    FinishedDay:  {project.EndDate}");
                if (project.StartDate > dtpStartDate.Value)//if project was started before the selected day add it cost to the total revenue
                    revenue += project.ExpectedCost;
                else
                {
                    TimeSpan projDuration = project.EndDate - project.StartDate;
                    TimeSpan projDurationInChosenPeriod = dtpStartDate.Value - project.StartDate;
                    revenue += projDurationInChosenPeriod.Days / projDuration.Days * project.ExpectedCost;//else add to the total revenue only project cost that was earn during period from
                    //the selected start day and project finished day
                }
            }
            TimeSpan duration = dtpEndDate.Value - dtpStartDate.Value;
            try
            {
                txtMonthRevenue.Text = Math.Round((revenue * 30 / duration.Days), 2).ToString();//calculate mounthly revenue
            }
            catch (DivideByZeroException)
            {
                txtMonthRevenue.Text = "0";
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }
    }
}
