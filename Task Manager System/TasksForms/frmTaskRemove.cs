using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskRemove : Form
    {
        private readonly frmMenu MainMenu;
        private readonly ITaskService _taskService;
        public frmTaskRemove(frmMenu menu, ITaskService taskService)
        {
            _taskService = taskService;
            MainMenu = menu;
            InitializeComponent();
        }

        private void dtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnTaskRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string taskId = new string(cmbTasksList.Text.TakeWhile(c => c != ':').ToArray());
                if(await _taskService.RemoveTaskFromProject(int.Parse(taskId)))
                {
                    MessageBox.Show("Task was removed");
                    cmbTasksList.Items.Remove(cmbTasksList.SelectedItem);
                    if (cmbTasksList.Items.Count > 0)
                        cmbTasksList.Text = cmbTasksList.Items[0].ToString();
                    return;
                }
                MessageBox.Show("A developer is working on this task");
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

        private async void frmTaskRemove_Load(object sender, EventArgs e)
        {
            cmbTasksList.DropDownStyle = ComboBoxStyle.DropDownList;
            List<Task> tasks = await _taskService.GetAll();
            foreach (Task task in tasks)
                cmbTasksList.Items.Add($"{task.Id}: {task.Name} {task.StartDate:dd-MM-yyyy} {task.Hours} {task.Priority}");
            if (tasks.Count > 0)
                cmbTasksList.Text = cmbTasksList.Items[0].ToString();
        }
    }
}
