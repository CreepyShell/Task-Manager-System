using System;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.ProjectForms
{
    public partial class frmProjectComplete : Form
    {
        private readonly frmMenu MainMenu;
        private readonly IProjectService projectService;
        public frmProjectComplete(frmMenu menu, IProjectService projectService)
        {
            InitializeComponent();
            MainMenu = menu;
            this.projectService = projectService;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu.Show();
        }

        private async void btnProjectComplete_Click(object sender, EventArgs e)
        {
            try
            {
                int projectId = int.Parse(new string(cboProject.Text.TakeWhile(c => c != ':').ToArray()));
                bool res = await projectService.CompleteProject(projectId);
                if (res)
                {
                    MessageBox.Show("Project was finished successfully");
                    this.btnBack_Click(sender, e);
                }
                MessageBox.Show("Deadline is expired");
            }
            catch (FormatException)
            {
                MessageBox.Show("No project is chosen");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Not found: " + ex.Message);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error: Project has unfinished tasks");
            }
            catch (Exception)
            {
                MessageBox.Show("Smt went wrong");
            } 
        }

        private async void frmProjectComplete_Load(object sender, EventArgs e)
        {
            cboProject.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach(Project project in await this.projectService.GetUnfinishedProject())
            {
                cboProject.Items.Add($"{project.Id}: {project.Name}  EndDate: {project.EndDate:dd-MM-yyyy} Status: {project.Status}");
            }
        }
    }
}
