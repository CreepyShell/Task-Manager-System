using FluentValidation;
using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Models;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskUpdate : Form
    {
        private readonly frmMenu MainMenu;
        private readonly ITaskService _taskService;
        private Task task;
        public frmTaskUpdate(frmMenu menu, ITaskService taskService)
        {
            _taskService = taskService; 
            InitializeComponent();
            MainMenu = menu;
        }

        private async void frmUpdateTask_Load(object sender, EventArgs e)
        {
            cboTask.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Task task in await _taskService.GetAll())
                cboTask.Items.Add($"{task.Id}: {task.Name} {task.StartDate:dd-MM-yyyy} {task.Hours} {task.Priority}");

            if (cboTask.Items.Count > 0)
                cboTask.SelectedItem = cboTask.Items[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void dtnTaskFind_Click(object sender, EventArgs e)
        {
            if (cboTask.Items.Count == 0)
            {
                MessageBox.Show("No tasks available");
                return;
            }

            task = await _taskService.GetById(int.Parse(new string(cboTask.Text.TakeWhile(c => c != ':').ToArray())));
            if (task == null)
            {
                MessageBox.Show("Task was not found");
                return;
            }

            txtTaskName.Text = task.Name;
            txtTaskDescription.Text = task.Description;
            txtTaskHours.Text = task.Hours.ToString();
            txtTaskStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTaskStatus.Text = task.Status.ToString();
            txtTaskPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTaskPriority.Text = task.Priority.ToString();

            this.grpTask.Visible = true;
            this.btnSaveTaskDetails.Visible = true;
        }

        private async void btnSaveTaskDetails_Click(object sender, EventArgs e)
        {
            if (task.Status == Status.Extended)
            {
                txtTaskStatus.Enabled = false;
            }

            try
            {
                task.Name = txtTaskName.Text;
                task.Description = txtTaskDescription.Text;
                task.Hours = int.Parse(txtTaskHours.Text);
                task.Priority = (Priority)Enum.Parse(typeof(Priority), txtTaskPriority.Text);
                task.Status = (Status)Enum.Parse(typeof(Status), txtTaskStatus.Text);
                await _taskService.UpdateTask(task.Id, task);
                MessageBox.Show("Task updated");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hours format");
                return;
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show("Data not found: " + ex.Message);
                return;
            }
            catch(ValidationException ex)
            {
                MessageBox.Show("Data invalid: " + ex.Message);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Smt went wrong: " + ex.Message);
                return;
            }

            this.grpTask.Visible = false;
            this.btnSaveTaskDetails.Visible = false;
        }
    }
}
