using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using FluentValidation;
using Task_Manager_System.Interfaces;
using Task_Manager_System.Models;
using Task_Manager_System.Services.Validators;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class TaskService : BaseService, ITaskService
    {
        private readonly IDevService _devService;
        private readonly TaskValidator taskValidator;
        public TaskService(IDevService devService)
        {
            _devService = devService;
            taskValidator = new TaskValidator();
        }
        public async Task<bool> AddTaskToProject(TMS_BLL.Models.Task newTask)
        {
            if (newTask == null)
                throw new ArgumentNullException(nameof(newTask), "Task is null");

            taskValidator.Validate(newTask, options => options.ThrowOnFailures());

            string devId = newTask.Developer == null ? "NULL" : newTask.Developer.Id.ToString();
            string sqlQuery = "INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) " +
                    $"VALUES ({newTask.Id}, '{newTask.Name}', '{newTask.Description}', TO_DATE('{newTask.StartDate.ToString("dd/MM/yyyy")}','DD/MM/YYYY')," +
                    $" {newTask.Hours}, '{newTask.Status}', '{newTask.Priority}', {newTask.Project.Id}, {devId})";

            await insertQuery(sqlQuery);
            return true;
        }

        public async Task<bool> AssignDeveloperToTask(int taskId, int devId)
        {
            Developer developer = await _devService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(Developer), "Developer is null");

            TMS_BLL.Models.Task task = await GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task in null");

            if (task.Status == Status.Finished)
                throw new ArgumentException("Task is finished");

            if (developer.Project != null && developer.Project.Id == task.Project.Id)
                throw new InvalidOperationException("Developer is assigned to a project and this project does not include a chosen task");

            if (task.Developer != null)
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = '{devId}', " +
                    $" WHERE TaskId = {taskId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteTask(int taskId)
        {
            TMS_BLL.Models.Task task = await GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task is null");

            if (task.StartDate.AddHours(task.Hours) < DateTime.Now)
                throw new ArgumentException("Task deadline is failed, a task can not be finished");

            if (task.Status == Status.Finished)
                return false;

            string updateQuery = "UPDATE tasks " +
                   $"SET Status = '{Status.Finished}', " +
                   $" WHERE TaskId = {task.Id}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<List<TMS_BLL.Models.Task>> GetAll()
        {
            string selectQuery = "SELECT * FROM tasks";
            return await GetAllTasksByQuery(selectQuery);
        }

        public async Task<List<TMS_BLL.Models.Task>> GetAllProjectTasks(int projId)
        {
            string selectQuery = $"SELECT * FROM tasks WHERE ProjectId={projId}";
            return await GetAllTasksByQuery(selectQuery);
        }

        public async Task<TMS_BLL.Models.Task> GetById(int id)
        {
            string selectQuery = "SELECT * FROM tasks" +
                                     $" Where TaskId = {id}";
            return await GetTask(selectQuery);
        }


        public async Task<TMS_BLL.Models.Task> GetByName(string name)
        {
            string selectQuery = "SELECT * FROM tasks" +
                                    $" Where Name = {name}";

            return await GetTask(selectQuery);
        }

        public async Task<List<TMS_BLL.Models.Task>> GetUnassignedAndUnfinishedTasks(int projId)
        {
            string selectQuery = $"SELECT * FROM tasks WHERE ProjectId = {projId} AND DeveloperId = NULL AND Status != 'finished'";
            return await GetAllTasksByQuery(selectQuery);
        }

        public async Task<bool> RemoveDeveloperFromTask(int taskId, int devId)
        {
            TMS_BLL.Models.Task task = await GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(task), "Task is null");

            Developer developer = await _devService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(developer), "Developer is null");

            if (task.Status == Status.Finished)
                throw new ArgumentException("Task is finished");

            if (task.Developer == null || task.Developer.Id != devId)
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = NULL, " +
                    $" WHERE TaskId = {taskId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> RemoveTaskFromProject(int taskId)
        {
            TMS_BLL.Models.Task task = await this.GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task is null");

            if (task.Developer != null)
                return false;

            string updateQuery = "DELETE FROM tasks " +
                    $" WHERE TaskId = {taskId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<TMS_BLL.Models.Task> UpdateTask(int idUpdatedTask, TMS_BLL.Models.Task updatedTask)
        {
            if (updatedTask == null || await GetById(idUpdatedTask) == null)
                throw new ArgumentNullException(nameof(updatedTask), "New task is null or old task was not found");

            taskValidator.Validate(updatedTask, options => options.ThrowOnFailures());

            string updateQuery = $"UPDATE tasks " +
                   $"SET Name = '{updatedTask.Name}', " +
                   $" Description = {updatedTask.Description}," +
                   $" Hours = '{updatedTask.Description}'," +
                   $" status = '{updatedTask.Status}'" +
                   $"Priority = '{updatedTask.Priority}'" +
                   $" WHERE projId = {idUpdatedTask}";

            await insertQuery(updateQuery);
            return await GetById(idUpdatedTask);
        }

        private async Task<TMS_BLL.Models.Task> GetTask(string query)
        {
            DataSet dataSet = await getDataSet(query);
            DataTable tasks = dataSet.Tables[0];

            if (tasks.Rows.Count == 0)
                return null;

            DataRow row = tasks.Rows[0];
            TMS_BLL.Models.Task task = new TMS_BLL.Models.Task()
            {
                Id = row.Field<short>(0),
                Name = row.Field<string>(1),
                Description = row.Field<string>(2),
                StartDate = row.Field<DateTime>(3),
                Hours = row.Field<short>(4),
                Status = (Status)Enum.Parse(typeof(Status), row.Field<string>(5)),
                Priority = (Priority)Enum.Parse(typeof(Priority), row.Field<string>(6)),
                Project = row.IsNull(7) ? null : new Project() { Id = row.Field<short>(7) },
                Developer = row.IsNull(8) ? null : new Developer() { Id = row.Field<short>(8) },
            };
            dataSet.Dispose();
            return task;
        }

        private async Task<List<TMS_BLL.Models.Task>> GetAllTasksByQuery(string query)
        {
            List<TMS_BLL.Models.Task> tasks = new List<TMS_BLL.Models.Task>();

            DataSet ds = await getDataSet(query);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
                return tasks;

            foreach (DataRow row in dt.Rows)
            {
                tasks.Add(new TMS_BLL.Models.Task()
                {
                    Id = row.Field<short>(0),
                    Name = row.Field<string>(1),
                    Description = row.Field<string>(2),
                    StartDate = row.Field<DateTime>(3),
                    Hours = row.Field<short>(4),
                    Status = (Status)Enum.Parse(typeof(Status), row.Field<string>(5)),
                    Priority = (Priority)Enum.Parse(typeof(Priority), row.Field<string>(6)),
                    Project = row.IsNull(7) ? null : new Project() { Id = row.Field<short>(7) },
                    Developer = row.IsNull(8) ? null : new Developer() { Id = row.Field<short>(8) },
                });
            }
            ds.Dispose();
            return tasks;
        }

        public async Task<List<TMS_BLL.Models.Task>> GetDeveloperTasks(int devId)
        {
            string selectQuery = "SELECT * FROM tasks" +
                                   $" Where DeveloperId = {devId}";

            return await GetAllTasksByQuery(selectQuery);
        }
    }
}
