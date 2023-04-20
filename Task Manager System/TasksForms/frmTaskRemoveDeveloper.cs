using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskRemoveDeveloper : Form
    {
        private readonly frmMenu MainMenu;
        private readonly ITaskService _taskService;
        private readonly IDevService _devService;
        public frmTaskRemoveDeveloper(frmMenu menu, ITaskService taskService, IDevService devService)
        {
            _taskService = taskService;
            _devService = devService;
            InitializeComponent();
            MainMenu = menu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnAssignDev_Click(object sender, EventArgs e)
        {
            try
            {
                int developerId = int.Parse(new string(cboDev.Text.TakeWhile(c => c != ':').ToArray()));

                int taskId = int.Parse(new string(cboTask.Text.TakeWhile(c => c != ':').ToArray()));

                if (await _taskService.RemoveDeveloperFromTask(taskId, developerId))
                {
                    MessageBox.Show("Developer was removed"); 
                    return;
                }
                MessageBox.Show("Task has no developer assigned to it or developer was not assigned to this task");
            }
            catch (FormatException)
            {
                MessageBox.Show("No task or developer chosen");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Data not found:" + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: smt went wrong");
            }
        }

        private async void frmTaskRemoveDeveloper_Load(object sender, EventArgs e)
        {
            cboTask.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Task task in await _taskService.GetAll())
            {
                cboTask.Items.Add($"{task.Id}: {task.Name} {task.StartDate:dd-MM-yyyy} {task.Hours} {task.Priority}    Developer: {task.Developer?.Id}    Project: {task.Project?.Id}");
            }
            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer developer in await _devService.GetAll())
            {
                cboDev.Items.Add($"{developer.Id}: {developer.FirstName} {developer.LastName}, {developer.Age} years. {developer.Specialization}  Project: {developer.Project?.Id}");
            }
        }

        private async void cboDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTask.Items.Clear();
            foreach (Task task in await _taskService.GetDeveloperTasks(int.Parse(new string(cboDev.Text.TakeWhile(c => c != ':').ToArray()))))
            {
                cboTask.Items.Add($"{task.Id}: {task.Name} {task.StartDate:dd-MM-yyyy} {task.Hours} {task.Priority}    Developer: {task.Developer?.Id}    Project: {task.Project?.Id}");
            }
        }
    }
}
