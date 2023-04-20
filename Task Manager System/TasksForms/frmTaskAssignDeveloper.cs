using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Interfaces;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskAssignDeveloper : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IDevService _devService;
        private readonly ITaskService _taskService;
        public frmTaskAssignDeveloper(frmMenu menu, IDevService devService, ITaskService taskService)
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

        private async void btnTaskAssignDeveloper_Click(object sender, EventArgs e)
        {
            if (cboTask.Items.Count == 0 || cboTask.Items.Count == 0)
            {
                MessageBox.Show("No developers or tasks are available");
                return;
            }
            try
            {
                int developerId = int.Parse(new string(cboDev.Text.TakeWhile(c => c != ':').ToArray()));

                int taskId = int.Parse(new string(cboTask.Text.TakeWhile(c => c != ':').ToArray()));

                await _taskService.AssignDeveloperToTask(taskId, developerId);
                MessageBox.Show("Developer was assigned");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Data not found:" + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: smt went wrong");
            }

        }

        private async void frmTaskAssignDeveloper_Load(object sender, EventArgs e)
        {
            cboTask.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Task task in await _taskService.GetUnassignedAndUnfinishedTasks())
                cboTask.Items.Add($"{task.Id}: {task.Name} {task.StartDate:dd-MM-yyyy} {task.Hours} {task.Priority}   Developer: {task.Developer?.Id}  Project: {task.Project?.Id}");
            if (cboTask.Items.Count > 0)
                cboTask.SelectedItem = cboTask.Items[0];

            cboDev.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Developer developer in await _devService.GetAll())
                cboDev.Items.Add($"{developer.Id}: {developer.FirstName} {developer.LastName}, {developer.Age} years. {developer.Specialization}    Project: {developer.Project?.Id}");
            if (cboDev.Items.Count > 0)
                cboDev.SelectedItem = cboDev.Items[0];
        }
    }
}
