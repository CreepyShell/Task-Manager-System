using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_System.TasksForms
{
    public partial class frmTaskUpdate : Form
    {
        private readonly frmMenu MainMenu;
        public frmTaskUpdate(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
        }

        private void frmUpdateTask_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private void dtnTaskFind_Click(object sender, EventArgs e)
        {
            this.grpTask.Visible = true;
        }
    }
}
