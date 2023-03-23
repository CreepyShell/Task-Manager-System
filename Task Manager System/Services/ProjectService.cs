using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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

                OracleTransaction transaction = connection.BeginTransaction();
                transaction.Commit();

                command.Dispose();
                connection.Close();
                return true;
            }
        }

        public async Task<bool> AssignDeveloperToProject(int projId, string devId)
        {
            if (await this.GetById(projId) == null)
                return false;
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = "UPDATE projects " +
                    $"SET developerid = '{devId}', " +
                    $" WHERE projectId = {projId}";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return true;
            }
        }

        public async Task<bool> CompleteProject(Project project)
        {
            if (await this.GetById(project.Id) == null)
                return false;
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = "UPDATE projects " +
                    "SET status = 'finished', " +
                    $" WHERE projId = {project.Id}";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return true;
            }
        }

        public async Task<List<Project>> GetAll()
        {
            List<Project> projects = new List<Project>();
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string selectQuery = "SELECT * FROM projects";
                OracleCommand command = new OracleCommand(selectQuery, connection);
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Project project = new Project()
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        StartDate = dr.GetDateTime(3),
                        EndDate = dr.GetDateTime(4),
                        ExpectedCost = dr.GetInt32(6)
                    };
                    projects.Add(project);
                }

                command.Dispose();
                connection.Close();
                return projects;
            }
        }

        public async Task<Project> GetById(int id)
        {
            Project project = null;
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = "SELECT * FROM projects" +
                                     $" Where ProjId={id}";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                OracleDataReader dr =  command.ExecuteReader();
                if (dr.Read())
                {
                    string descr;
                    Status currStatus = Status.Started;
                    try
                    {
                        descr = dr.GetString(2);
                        Enum.TryParse(dr.GetString(5), out currStatus);
                    }
                    catch (InvalidCastException)
                    {
                        descr = "";
                    }
                    project = new Project()
                    {
                        Id = dr.GetInt32(0),
                        Name = dr.GetString(1),
                        Description = descr,
                        StartDate = dr.GetDateTime(3),
                        EndDate = dr.GetDateTime(4),
                        Status = currStatus,
                        ExpectedCost = dr.GetInt32(6)
                    };
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

        public async Task<Project> UpdateProject(int idOldProject, Project newProject)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string updateQuery = $"UPDATE projects " +
                    $"SET projectname = '{newProject.Name}', " +
                    $" expectedcost = {newProject.ExpectedCost}," +
                    $" projectdescription = '{newProject.Description}'," +
                    $" enddate = TO_DATE('{newProject.EndDate.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY')," +
                    $" status = '{newProject.Status}'" +
                    $" WHERE projId = {idOldProject}";

                OracleCommand command = new OracleCommand(updateQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return newProject;
            }
        }
    }
}
