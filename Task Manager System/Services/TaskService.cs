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

            taskValidator.Validate(newTask, options => options.ThrowOnFailures());//if failed a Validation exception is thrown

            string devId = newTask.Developer == null ? "NULL" : newTask.Developer.Id.ToString();
            string sqlQuery = "INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) " +
                    $"VALUES ({newTask.Id}, '{newTask.Name}', '{newTask.Description}', TO_DATE('{newTask.StartDate.ToString("dd/MM/yyyy HH:mm")}','DD/MM/YYYY:HH24:MI')," +
                    $" {newTask.Hours}, '{newTask.Status}', '{newTask.Priority}', {newTask.Project.Id}, {devId})";

            await ExecuteNonQuery(sqlQuery);
            return true;
        }

        public async Task<bool> AssignDeveloperToTask(int taskId, int devId)
        {
            Developer developer = await _devService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(Developer), "Developer is null");//developer is not found

            TMS_BLL.Models.Task task = await GetById(taskId);//task is not found
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task in null");//task is not found

            if (task.Status == Status.Finished)
                throw new ArgumentException("Task is finished");//if task is finished, it can not be assigned to a developer

            //check if developer is assinged to a project and the chosen task also belongs this project
            if (developer.Project != null && developer.Project.Id != task.Project.Id)//if developer is assigned to a project, a task from other project can not be assigned to this developer
                throw new InvalidOperationException("Developer is assigned to a project and this project does not include a chosen task");

            if (task.Developer != null)//if task is already assigned to a developer, it can not be assigned to other developer
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = '{devId}' " +
                    $" WHERE TaskId = {taskId}";

            await ExecuteNonQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteTask(int taskId)
        {
            TMS_BLL.Models.Task task = await GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task is null");//task is not found

            if (task.StartDate.AddHours(task.Hours) < DateTime.Now)
                throw new ArgumentException("Task deadline is failed, a task can not be finished");//deadline is expired

            if (task.Status == Status.Finished)//check if task is already finished
                return false;

            string updateQuery = "UPDATE tasks " +
                   $"SET Status = '{Status.Finished}' " +
                   $" WHERE TaskId = {task.Id}";

            await ExecuteNonQuery(updateQuery);

            return true;
        }
        public async Task<List<TMS_BLL.Models.Task>> GetAll()
        {
            string selectQuery = "SELECT * FROM tasks";
            return await GetAllTasksByQuery(selectQuery);
        }

        public async Task<List<TMS_BLL.Models.Task>> GetAllProjectTasks(int projId)
        {
            string selectQuery = $"SELECT * FROM tasks WHERE ProjectId={projId}";//get all tasks from one project
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
                                    $" Where Name = '{name}'";

            return await GetTask(selectQuery);
        }

        public async Task<List<TMS_BLL.Models.Task>> GetUnassignedAndUnfinishedTasks()//get all tasks with no developer assinged to it and do not have finished statuses
        {
            string selectQuery = $"SELECT * FROM tasks WHERE DeveloperId IS NULL AND Status != '{Status.Finished}'";
            return await GetAllTasksByQuery(selectQuery);
        }

        public async Task<bool> RemoveDeveloperFromTask(int taskId, int devId)
        {
            TMS_BLL.Models.Task task = await GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(task), "Task is null");//task is not found

            Developer developer = await _devService.GetDeveloperById(devId);
            if (developer == null)
                throw new ArgumentNullException(nameof(developer), "Developer is null");//developer is not found

            if (task.Status == Status.Finished)//check if task is finished
                throw new ArgumentException("Task is finished");

            if (task.Developer == null || task.Developer.Id != devId)//check if task has any developer assigned to it and this task was assigned to the chosen developer
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = NULL " +
                    $" WHERE TaskId = {taskId}";

            await ExecuteNonQuery(updateQuery);

            return true;
        }

        public async Task<bool> RemoveTaskFromProject(int taskId)
        {
            TMS_BLL.Models.Task task = await this.GetById(taskId);
            if (task == null)
                throw new ArgumentNullException(nameof(TMS_BLL.Models.Task), "Task is null");//task is not found

            if (task.Developer != null && task.Status != Status.Finished)//check if developer is working on a task and task is not finished
                return false;

            string updateQuery = "DELETE FROM tasks " +
                    $" WHERE TaskId = {taskId}";

            await ExecuteNonQuery(updateQuery);

            return true;
        }

        public async Task<TMS_BLL.Models.Task> UpdateTask(int idUpdatedTask, TMS_BLL.Models.Task updatedTask)
        {
            if (updatedTask == null || await GetById(idUpdatedTask) == null)
                throw new ArgumentNullException(nameof(updatedTask), "New task is null or old task was not found");

            taskValidator.Validate(updatedTask, options => options.ThrowOnFailures());//ValidationException is thrown if task is invalid

            string updateQuery = $"UPDATE tasks " +
                   $"SET Name = '{updatedTask.Name}', " +
                   $" Description = '{updatedTask.Description}'," +
                   $" Hours = '{updatedTask.Hours}'," +
                   $" status = '{updatedTask.Status}'," +
                   $" Priority = '{updatedTask.Priority}'" +
                   $" WHERE TaskId = {idUpdatedTask}";

            await ExecuteNonQuery(updateQuery);
            return await GetById(idUpdatedTask);
        }

        private async Task<TMS_BLL.Models.Task> GetTask(string query)
        {
            DataSet dataSet = await ExecuteQuery(query);
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

            DataSet ds = await ExecuteQuery(query);

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

        public async Task<List<TMS_BLL.Models.Task>> GetDeveloperTasks(int devId)//get all tasks that were assigned to a developer with id devId
        {
            string selectQuery = "SELECT * FROM tasks" +
                                   $" Where DeveloperId = {devId}";

            return await GetAllTasksByQuery(selectQuery);
        }
    }
}
