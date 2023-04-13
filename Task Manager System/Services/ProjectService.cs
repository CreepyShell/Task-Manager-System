using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class ProjectService : BaseService, IProjectService
    {
        public ProjectService()
        {

        }
        public async Task<bool> AddProject(Project newProject)
        {
            string sqlQuery = "INSERT INTO Projects Values (" +
                  newProject.Id + ",'" +
                  newProject.Name + "','" +
                  newProject.Description + "'," +
                  "TO_DATE('" + newProject.StartDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + "," +
                  "TO_DATE('" + newProject.EndDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + ",'" +
                  newProject.Status + "'," +
                  newProject.ExpectedCost + ")";

            await insertQuery(sqlQuery);

            return true;
        }

        public async Task<bool> AssignDeveloperToProject(int projId, string devId)
        {
            if (await this.GetById(projId) == null)
                return false;

            string updateQuery = "UPDATE projects " +
                    $"SET developerId = '{devId}', " +
                    $" WHERE projectId = {projId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteProject(Project project)
        {
            if (await GetById(project.Id) == null)
                return false;

            string updateQuery = "UPDATE projects " +
                   "SET status = 'finished', " +
                   $" WHERE projId = {project.Id}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<List<Project>> GetAll()
        {
            List<Project> projects = new List<Project>();
            string selectQuery = "SELECT * FROM projects";

            DataSet ds = await getDataSet(selectQuery);

            DataTable dt = ds.Tables["projects"];

            if (dt.Rows.Count == 0)
                return projects;

            foreach (DataRow row in dt.Rows)
            {
                projects.Add(new Project()
                {
                    Id = (int)row["ProjId"],
                    Name = (string)row["ProjectName"],
                    Description = (string)row["ProjectDescription"],
                    StartDate = (DateTime)row["StartDate"],
                    EndDate = (DateTime)row["EndDate"],
                    Status = (Status)row["Status"],
                    ExpectedCost = (decimal)row["ExpectedCost"]
                });
            }
            ds.Dispose();
            return projects;
        }

        public async Task<Project> GetById(int id)
        {
            string selectQuery = "SELECT * FROM projects" +
                                     $" Where ProjId = {id}";
            return await GetProject(selectQuery);
        }

        public async Task<Project> GetByName(string name)
        {
            string selectQuery = $"SELECT * FROM projects WHERE ProjectName = {name}";
            return await GetProject(selectQuery);
        }

        public async Task<Project> UpdateProject(int idOldProject, Project newProject)
        {
            string updateQuery = $"UPDATE projects " +
                   $"SET projectname = '{newProject.Name}', " +
                   $" expectedcost = {newProject.ExpectedCost}," +
                   $" projectdescription = '{newProject.Description}'," +
                   $" enddate = TO_DATE('{newProject.EndDate.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY')," +
                   $" status = '{newProject.Status}'" +
                   $" WHERE projId = {idOldProject}";

            await insertQuery(updateQuery);
            return await GetById(idOldProject);
        }

        private async Task<Project> GetProject(string query)
        {
            DataSet dataSet = await getDataSet(query);
            DataTable projects = dataSet.Tables["projects"];

            if (projects.Rows.Count == 0)
                return null;

            DataRow row = projects.Rows[0];
            Project project = new Project()
            {
                Id = (int)row["ProjId"],
                Name = (string)row["ProjectName"],
                Description = (string)row["ProjectDescription"],
                StartDate = (DateTime)row["StartDate"],
                EndDate = (DateTime)row["EndDate"],
                Status = (Status)row["Status"],
                ExpectedCost = (decimal)row["ExpectedCost"]
            };
            dataSet.Dispose();
            return project;
        }
    }
}
