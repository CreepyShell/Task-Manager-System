using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskComplete : Form
    {
        private readonly frmMenu MainMenu;
        private readonly ITaskService _taskService;
        public frmTaskComplete(frmMenu menu, ITaskService taskService)
        {
            InitializeComponent();
            MainMenu = menu;
            _taskService = taskService;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnCompleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                int taskId = int.Parse(new string(cboTask.Text.TakeWhile(c => c != ':').ToArray()));

                if (await _taskService.CompleteTask(taskId))
                {
                    MessageBox.Show("Task was finished");
                    return;
                }
                MessageBox.Show("Task is already finished");
            }
            catch (FormatException)
            {
                MessageBox.Show("No task is chosen");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Data not found:" + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Error: smt went wrong");
            //}
        }

        private async void frmTaskComplete_Load(object sender, EventArgs e)
        {
            cboTask.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Task task in await _taskService.GetAll())
            {
                cboTask.Items.Add($"{task.Id}: {task.Name}   Deadline: {task.StartDate:dd-MM-yyyy}   Hours: {task.Hours}    Priority: {task.Priority}  " +
                    $"    Status: {task.Status}     DevId: {task.Developer?.Id}");
            }
        }
    }
}
