using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Threading.Tasks;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class ProjectService : IProjectService
    {
        public async Task<bool> AddProject(Project newProject)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string sqlQuery = "INSERT INTO Projects Values (" +
                  newProject.Id + ",'" +
                  newProject.Name + "','" +
                  newProject.Description + "'," +
                  "TO_DATE('" + newProject.StartDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + "," +
                  "TO_DATE('" + newProject.EndDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + ",'" +
                  newProject.Status + "'," +
                  newProject.ExpectedCost + ")";

                OracleCommand command = new OracleCommand(sqlQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return true;
            }
        }

        public Task<bool> AssignDeveloperToProject(string projId, string devId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CompleteProject(Project project)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Project> GetById(string id)
        {
            Project project = null;
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = "SELECT * FROM projects" +
                                     $"Where ProjId={id}";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                OracleDataReader dr =  command.ExecuteReader();
                if (dr.Read())
                {
                    project.Id = dr.GetInt32(0);
                    project.Name = dr.GetString(1);
                    project.Description = dr.GetString(3);
                    project.StartDate = dr.GetDateTime(4);
                    project.EndDate = dr.GetDateTime(5);
                    //project.Status = dr.GetString(6);
                    project.ExpectedCost = dr.GetInt32(7);
                }
                command.Dispose();
                connection.Close();
                return project;
            }
        }

        public Task<Project> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Project> UpdateProject(string idOldProject, Project newProject)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = $"UPDATE projects " +
                    $"SET projectname = '{newProject.Name}', " +
                    $"expectedcost = {newProject.ExpectedCost}" +
                    $"" +
                    $" WHERE projId = {idOldProject};";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return await GetById(idOldProject);
            }
        }
    }
}
