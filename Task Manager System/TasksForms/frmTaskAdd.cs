using System;
using System.Linq;
using System.Windows.Forms;
using Task_Manager_System.Models;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskAdd : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmTaskAdd(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
        }


        private void txtBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Id = int.Parse(txtTaskId.Text);
            if (txtName.Text.Length > 20 || txtName.Text.Length < 5)
            {
                MessageBox.Show("Name must be greater than 5 symbols and less than 20 symbols");
                return;
            }
            task.Name = txtName.Text;

            if (txtDescription.Text.Length > 200)
            {
                MessageBox.Show("Description must be less than 200 symblos");
                return;
            }
            task.Description = txtDescription.Text;
            task.StartDate = dtpStartTime.Value;
            try
            {
                int hours = int.Parse(txtTaskHours.Text);
                if (hours < 0 || hours > 72)
                {
                    MessageBox.Show("Task hours mush be greater than 0 and less than 72");
                    return;
                }
                task.Hours = hours;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid hours format");
                return;
            }
            task.Priority = (Priority)Enum.Parse(typeof(Priority), cmbPriority.Text);
            Project project = db.Projects.FirstOrDefault(p => p.Id.ToString() == txtProjId.Text);
            if (project == null)
            {
                MessageBox.Show("Project was not found");
                return;
            }
            db.Tasks.Add(task);
            MessageBox.Show("Task added");
            txtTaskId.Text = Guid.NewGuid().ToString();
        }

        private void frmTaskAdd_Load(object sender, EventArgs e)
        {
            dtpStartTime.MinDate = DateTime.Now;
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Text = cmbPriority.Items[0].ToString();
            txtTaskId.Text = Guid.NewGuid().ToString();
        }
    }
}
