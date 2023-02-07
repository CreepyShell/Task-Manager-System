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

        public Task<Project> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> UpdateProject(string idOldProject, Project newProject)
        {
            throw new System.NotImplementedException();
        }
    }
}
