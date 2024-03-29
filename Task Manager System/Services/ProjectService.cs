﻿using FluentValidation;
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

            _projectValidator.Validate(newProject, op => op.ThrowOnFailures());//if validation is failed Validation exception is thrown

            string sqlQuery = "INSERT INTO Projects Values (" +
                  newProject.Id + ",'" +
                  newProject.Name + "','" +
                  newProject.Description + "'," +
                  "TO_DATE('" + newProject.StartDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + "," +
                  "TO_DATE('" + newProject.EndDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" + ",'" +
                  newProject.Status + "'," +
                  newProject.ExpectedCost + ")";

            await ExecuteNonQuery(sqlQuery);

            return true;
        }

        public async Task<bool> AssignDeveloperToProject(int projId, int devId)
        {
            Project project = await GetById(projId);
            if (project == null)
                throw new ArgumentNullException(nameof(Project), "Project is null");//project is not found

            Developer developer = await _developerService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(Developer), "Developer is null");//developer is not found

            if (project.Status == Status.Finished)
                throw new ArgumentException("Project is finished");//check if project is not finished

            //check if developer was not assinged to other project and does not have any tasks to do
            if (developer.Project != null || (await _taskService.GetDeveloperTasks(devId)).Any(t => t.Status != Status.Finished))
                return false;

            string updateQuery = "UPDATE DEVELOPERS " +
                    $"SET ProjectId = {projId} " +
                    $" WHERE DevId = {devId}";

            await ExecuteNonQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteProject(int projectId)
        {
            Project project = await GetById(projectId);
            if (project == null)
                throw new ArgumentNullException(nameof(Project), "Project was not found or just null");//project is not found

            if ((await _taskService.GetAllProjectTasks(project.Id)).Any(t => t.Status != Status.Finished))//check if project has any unfinished tasks
                throw new ArgumentException("Project has unfinished tasks");

            if (project.EndDate < DateTime.Now)//check if deadline was not expired
                return false;

            string updateProject = "UPDATE projects " +
                   "SET status = 'Finished'," +
                   "EndDate =  TO_DATE('" + DateTime.Now.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                   $" WHERE projId = {project.Id}";//set project status finished

            await ExecuteNonQuery(updateProject);

            string updateDeveloper = "UPDATE developers " +
                   "SET ProjectId = NULL" +
                   $" WHERE ProjectId = {project.Id}";//remove all developers from the finished project

            await ExecuteNonQuery(updateDeveloper);

            return true;
        }

        public async Task<List<Project>> GetAll()
        {
            List<Project> projects = new List<Project>();
            string selectQuery = "SELECT * FROM projects";

            DataSet ds = await ExecuteQuery(selectQuery);

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
            string selectQuery = $"SELECT * FROM projects WHERE ProjectName = '{name}'";
            return await GetProject(selectQuery);
        }

        public async Task<Project> GetProjectWithDevelopers(int projectId)//get project with a developer assigned to it
        {
            string query = "SELECT * FROM PROJECTS LEFT JOIN DEVELOPERS ON PROJECTS.PROJID = DEVELOPERS.PROJECTID WHERE PROJECTS.PROJID = " + projectId;
            DataSet dataSet = await ExecuteQuery(query);
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
                ExpectedCost = (decimal)row.Field<double>(6),
                Developers = new List<Developer>()
            };
            foreach (DataRow row_dev in projects.Rows)
            {
                if (!row_dev.IsNull(7))
                {
                    project.Developers.Add(new Developer()
                    {
                        Id = row_dev.Field<short>(7),
                        FirstName = row_dev.Field<string>(8),
                        LastName = row_dev.Field<string>(9),
                        Specialization = row_dev.Field<string>(10),
                        Age = row_dev.Field<short>(11)
                    });
                }
            }
            dataSet.Dispose();
            return project;
        }

        public async Task<List<Project>> GetUnfinishedProjects()//get all projects that do not have finished status
        {
            List<Project> projects = new List<Project>();
            string selectQuery = "SELECT * FROM projects WHERE Status != 'Finished'";

            DataSet ds = await ExecuteQuery(selectQuery);

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

            await ExecuteNonQuery(updateQuery);
            return await GetById(idOldProject);
        }

        private async Task<Project> GetProject(string query)
        {
            DataSet dataSet = await ExecuteQuery(query);
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
