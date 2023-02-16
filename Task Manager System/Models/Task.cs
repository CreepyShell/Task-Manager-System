using Oracle.ManagedDataAccess.Client;
using System;
using Task_Manager_System;
using Task_Manager_System.Models;

namespace TMS_BLL.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Hours { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Project Project { get; set; }
        public Developer Developer { get; set; }

        public static int GetNextTaskId()
        {
            int nextId = 0;
            string sql = "select MAX(TaskId) from Tasks";
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.IsDBNull(0))
                    return 0;
                nextId = dr.GetInt16(0);
                command.Dispose();
                connection.Close();
            }
            return nextId + 1;
        }
    }
}
