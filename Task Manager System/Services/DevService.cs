using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Manager_System.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class DevService : IDevService
    {
        public DevService()
        {

        }

        public async Task<List<Developer>> GetAll()
        {
            List<Developer> developers = new List<Developer>();
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string selectQuery = "SELECT * FROM developers";
                OracleCommand command = new OracleCommand(selectQuery, connection);
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Developer developer = new Developer()
                    {
                        Id = dr.GetInt32(0),
                        Age = dr.GetInt16(4),
                        Specialization = dr.GetString(3),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Project = new Project() { Id = dr.GetInt16(5) }
                    };
                    developers.Add(developer);
                }

                command.Dispose();
                connection.Close();
                return developers;
            }
        }

        public async Task<Developer> GetDeveloperById(int id)
        {
            Developer developer = null;
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string selectQuery = "SELECT * FROM developers" +
                                     $" Where DevId={id}";

                OracleCommand command = new OracleCommand(selectQuery, connection);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    developer = new Developer()
                    {
                        Id = dr.GetInt32(0),
                        Age = dr.GetInt16(4),
                        Specialization = dr.GetString(3),
                        FirstName = dr.GetString(1),
                        LastName = dr.GetString(2),
                        Project = new Project() { Id = dr.GetInt16(5) }
                    };
                }

                command.Dispose();
                connection.Close();
                return developer;
            }
        }

        public Task<Developer> GetDeveloperByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
