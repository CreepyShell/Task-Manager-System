using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Task_Manager_System.Interfaces;
using Task_Manager_System.Services.Validators;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class ProjectService : BaseService, IProjectService
    {
        private readonly ProjectValidator _projectValidator;
        private readonly IDevService _developerService;
        private readonly ITaskService _taskService;
        public ProjectService(IDevService devService, ITaskService taskService)
        {
            _developerService = devService;
            _projectValidator = new ProjectValidator();
            _taskService = taskService;
        }
        public async Task<bool> AddProject(Project newProject)
        {
            if (newProject == null)
                throw new ArgumentNullException(nameof(newProject));

            _projectValidator.Validate(newProject, op => op.ThrowOnFailures());

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

        public async Task<bool> AssignDeveloperToProject(int projId, int devId)
        {
            Project project = await GetById(projId);
            if (project == null)
                throw new ArgumentNullException(nameof(Project), "Project is null");

            Developer developer = await _developerService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(Developer), "Developer is null");

            if (project.Status == Status.Finished)
                throw new ArgumentException("Project is finished");

            if (developer.Project != null || (await _taskService.GetDeveloperTasks(devId)).Count != 0)
                return false;

            string updateQuery = "UPDATE projects " +
                    $"SET developerId = '{devId}', " +
                    $" WHERE projectId = {projId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteProject(int projectId)
        {
            Project project = await GetById(projectId);
            if (project == null)
                throw new ArgumentNullException(nameof(Project), "Project was not found or just null");

            if ((await _taskService.GetAllProjectTasks(project.Id)).Any(t => t.Status != Status.Finished))
                throw new ArgumentException("Project has unfinished tasks");

            if (project.EndDate < DateTime.Now)
                return false;

            string updateProject = "UPDATE projects " +
                   "SET status = 'finished'," +
                   "EndDate =  TO_DATE('" + DateTime.Now.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                   $" WHERE projId = {project.Id}";

            await insertQuery(updateProject);

            string updateDeveloper = "UPDATE developers " +
                   "SET ProjectId = NULL," +
                   $" WHERE projId = {project.Id}";

            await insertQuery(updateDeveloper);

            return true;
        }

        public async Task<List<Project>> GetAll()
        {
            List<Project> projects = new List<Project>();
            string selectQuery = "SELECT * FROM projects";

            DataSet ds = await getDataSet(selectQuery);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
                return projects;

            foreach (DataRow row in dt.Rows)
            {
                projects.Add(new Project()
                {
                    Id = row.Field<short>(0),
                    Name = row.Field<string>(1),
                    Description = row.Field<string>(2),
                    StartDate = row.Field<DateTime>(3),
                    EndDate = row.Field<DateTime>(4),
                    Status = (Status)Enum.Parse(typeof(Status), row.Field<string>(5)),
                    ExpectedCost = (decimal)row.Field<double>(6)
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
            if (newProject == null)
                throw new ArgumentNullException(nameof(newProject));

            _projectValidator.Validate(newProject, op => op.ThrowOnFailures());

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
            DataTable projects = dataSet.Tables[0];

            if (projects.Rows.Count == 0)
                return null;

            DataRow row = projects.Rows[0];
            Project project = new Project()
            {
                Id = row.Field<short>(0),
                Name = row.Field<string>(1),
                Description = row.Field<string>(2),
                StartDate = row.Field<DateTime>(3),
                EndDate = row.Field<DateTime>(4),
                Status = (Status)Enum.Parse(typeof(Status), row.Field<string>(5)),
                ExpectedCost = (decimal)row.Field<double>(6)
            };
            dataSet.Dispose();
            return project;
        }
    }
}
