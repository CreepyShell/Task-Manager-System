using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskRemove : Form
    {
        private readonly frmMenu MainMenu;
        private readonly TasksDb db;
        public frmTaskRemove(frmMenu menu)
        {
            MainMenu = menu;
            db = TasksDb.GetTasksDb();
            InitializeComponent();
        }

        private void dtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void btnTaskRemove_Click(object sender, EventArgs e)
        {
            if(db.Tasks.Count == 0)
            {
                MessageBox.Show("No tasks in db");
                return;
            }
            string taskStr = cmbTasksList.Text.Split(',')[1].Trim();
            Task task = db.Tasks.FirstOrDefault(t => t.Id == taskStr);
            db.Tasks.Remove(task);
            cmbTasksList.Items.Remove(cmbTasksList.SelectedItem);
            if (db.Tasks.Count > 0)
                cmbTasksList.Text = cmbTasksList.Items[0].ToString();
        }

        private void frmTaskRemove_Load(object sender, EventArgs e)
        {
            cmbTasksList.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Task task in db.Tasks)
                cmbTasksList.Items.Add(task.Name + ", " + task.Id);
            if (db.Tasks.Count > 0)
                cmbTasksList.Text = cmbTasksList.Items[0].ToString();
        }
    }
}
