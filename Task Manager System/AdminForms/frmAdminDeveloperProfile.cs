﻿using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.AdminForms
{
    public partial class frmAdminDeveloperProfile : Form
    {
        private readonly IDevService _devService;
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmAdminDeveloperProfile(frmMenu menu, IDevService devService)
        {
            _devService = devService;
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }

        private void btnFindDeveloper_Click(object sender, EventArgs e)
        {
            txtProjectInfo.Clear();
            txtTasksInfo.Items.Clear();
            Developer developer = db.Developers.FirstOrDefault(d => d.Id.ToString() == new string(cboDev.Text.TakeWhile(c => c != ':').ToArray()));
            if (developer == null)
            {
                MessageBox.Show("Developer was not found");
                return;
            }
            Task[] tasks = db.Tasks.Where(t => t.Developer.Id == developer.Id).ToArray();
            foreach (Task task in tasks)
                txtTasksInfo.Items.Add($"{task.Name}--{task.Hours}--{task.Status}--{task.Project}");
            if(developer.Project != null)
            {
                txtProjectInfo.Text = $"{developer.Project.Name}--{developer.Project.Status}--{developer.Project.StartDate}--{developer.Project.EndDate}";
                return;
            }
            txtProjectInfo.Text = "Null";
        }

        private async void frmAdminDeveloperProfile_Load(object sender, EventArgs e)
        {
            txtTasksInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer developer in await _devService.GetAll())
            {
                cboDev.Items.Add($"{developer.Id}: {developer.FirstName} {developer.LastName}, {developer.Age} years. {developer.Specialization}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show(); 
        }
    }
}
