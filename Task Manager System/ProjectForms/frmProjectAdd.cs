using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_System
{
    public partial class frmProjectAdd : Form
    {
        public frmMenu MainMenu { get; }
        public frmProjectAdd()
        {
            InitializeComponent();
        }

        public frmProjectAdd(frmMenu menu)
        {
            MainMenu = menu;
            InitializeComponent();
        }

        private void frmProjectAdd_Load(object sender, EventArgs e)
        {
            txtProjId.Text = Guid.NewGuid().ToString();
            dtpDateStart.MinDate = DateTime.Today;
            dtpDateEnd.MinDate = DateTime.Today.AddDays(1);
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtpDateEnd.MinDate = dtpDateStart.Value.AddDays(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainMenu != null)
                MainMenu.Show();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string description = txtDescription.Text;
                DateTime startDate = dtpDateStart.Value;
                DateTime endDate = dtpDateEnd.Value;
                double expectedCost = Convert.ToDouble(txtExpectedCost.Text);
                //call method addProject
            }
            catch(FormatException)
            {
                MessageBox.Show("Expected cost must be numeric");
            }
        }

        private void grpProject_Enter(object sender, EventArgs e)
        {

        }
    }
}
