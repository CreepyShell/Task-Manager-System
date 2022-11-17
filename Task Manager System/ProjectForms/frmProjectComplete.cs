using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectComplete : Form
    {
        private readonly frmMenu MainMenu;
        public frmProjectComplete(frmMenu menu)
        {
            InitializeComponent();
            MainMenu = menu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }
    }
}
