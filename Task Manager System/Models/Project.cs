using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Manager_System;

namespace TMS_BLL.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status Status { get; set; }
        public decimal ExpectedCost { get; set; }
        public List<Developer> Developers { get; set; }
        public List<Task> Tasks { get; set; }


        public static int GetNextProjId()
        {
            int nextId = 0;
            string sql = "select MAX(ProjId) from Projects";
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.IsDBNull(0))
                    return 0;
                nextId = int.Parse(dr.GetString(0));
                command.Dispose();
                connection.Close();
            }
            return nextId + 1;
        }
    }
}
