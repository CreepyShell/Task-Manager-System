using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TMS_BLL.Models;

namespace Task_Manager_System
{
    public partial class frmConnect : Form
    {
        private OracleConnection connection = new OracleConnection(DbConnect.oradb);
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                return;
            connection.Open();
            lblStatus.Text = "Connection is opened";
        }

        private void dbtDisconnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                return;

            TasksDb db = TasksDb.GetTasksDb();
            Project project = db.Projects.Last();
            string sqlQuery = "INSERT INTO Projects Values ('" +
              project.Id + "','" +
              project.Name + "','" +
              project.Description + "'," +
              "TO_DATE('" + project.StartDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + "," +
              "TO_DATE('" + project.EndDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + ",'" +
              project.Status + "'," +
              project.ExpectedCost + ")";

            OracleCommand command = new OracleCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            lblStatus.Text = "Connection is closed";
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
