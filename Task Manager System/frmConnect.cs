using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

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
            connection.Close();
            lblStatus.Text = "Connection is closed";
            OracleCommand command = new OracleCommand();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
