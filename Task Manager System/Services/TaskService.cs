using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Task_Manager_System.Models;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class TaskService : BaseService, ITaskService
    {
        public TaskService()
        {

        }
        public async Task<bool> AddTaskToProject(TMS_BLL.Models.Task newTask)
        {
            string sqlQuery = "INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) " +
                    $"VALUES ({newTask.Id}, '{newTask.Name}', '{newTask.Description}', TO_DATE('{newTask.StartDate.ToString("dd/MM/yyyy")}','DD/MM/YYYY')," +
                    $" {newTask.Hours}, '{newTask.Status}', '{newTask.Priority}', {newTask.Project.Id}, {newTask.Developer.Id})";

            await insertQuery(sqlQuery);
            return true;
        }

        public async Task<bool> AssignDeveloperToTask(int taskId, int devId)
        {
            if (await this.GetById(taskId) == null)
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = '{devId}', " +
                    $" WHERE TaskId = {taskId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> CompleteTask(TMS_BLL.Models.Task task)
        {
            if (await GetById(task.Id) == null)
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

        public async Task<TMS_BLL.Models.Task[]> GetAllProjectTasks(int projId)
        {
            string selectQuery = $"SELECT * FROM tasks WHERE ProjectId={projId}";
            return (await GetAllTasksByQuery(selectQuery)).ToArray();
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

        public async Task<TMS_BLL.Models.Task[]> GetUnassignedAndUnfinishedTasks(int projId)
        {
            string selectQuery = $"SELECT * FROM tasks WHERE ProjectId = {projId} AND DeveloperId = NULL AND Status != 'finished'";
            return (await GetAllTasksByQuery(selectQuery)).ToArray();
        }

        public async Task<bool> RemoveDeveloperFromTask(int taskId, int devId)
        {
            if (await this.GetById(taskId) == null)
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET developerId = NULL, " +
                    $" WHERE TaskId = {taskId}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<bool> RemoveTaskFromProject(TMS_BLL.Models.Task task)
        {
            if (await this.GetById(task.Id) == null)
                return false;

            string updateQuery = "UPDATE tasks " +
                    $"SET ProjectId = NULL, " +
                    $" WHERE TaskId = {task.Id}";

            await insertQuery(updateQuery);

            return true;
        }

        public async Task<TMS_BLL.Models.Task> UpdateTask(int idUpdatedTask, TMS_BLL.Models.Task updatedTask)
        {
            string updateQuery = $"UPDATE tasks " +
                   $"SET Name = '{updatedTask.Name}', " +
                   $" Description = {updatedTask.Description}," +
                   $" Hours = '{updatedTask.Description}'," +
                   $" status = '{updatedTask.Status}'" +
                   $"Priority = '{updatedTask.Project}'" +
                   $" WHERE projId = {idUpdatedTask}";

            await insertQuery(updateQuery);
            return await GetById(idUpdatedTask);
        }

        private async Task<TMS_BLL.Models.Task> GetTask(string query)
        {
            DataSet dataSet = await getDataSet(query);
            DataTable tasks = dataSet.Tables["tasks"];

            if (tasks.Rows.Count == 0)
                return null;

            DataRow row = tasks.Rows[0];
            TMS_BLL.Models.Task task = new TMS_BLL.Models.Task()
            {
                Id = (int)row["TaskId"],
                Name = (string)row["Name"],
                Description = (string)row["Description"],
                StartDate = (DateTime)row["StartDate"],
                Hours = (int)row["Hours"],
                Status = (Status)row["Status"],
                Priority = (Priority)row["Priority"],
                Developer = new Developer() { Id = (int)row["DeveloperId"] },
                Project = new Project() { Id = (int)row["ProjectId"] },
            };
            dataSet.Dispose();
            return task;
        }

        private async Task<List<TMS_BLL.Models.Task>> GetAllTasksByQuery(string query)
        {
            List<TMS_BLL.Models.Task> tasks = new List<TMS_BLL.Models.Task>();

            DataSet ds = await getDataSet(query);

            DataTable dt = ds.Tables["tasks"];

            if (dt.Rows.Count == 0)
                return tasks;

            foreach (DataRow row in dt.Rows)
            {
                tasks.Add(new TMS_BLL.Models.Task()
                {
                    Id = (int)row["TaskId"],
                    Name = (string)row["Name"],
                    Description = (string)row["Description"],
                    StartDate = (DateTime)row["StartDate"],
                    Hours = (int)row["Hours"],
                    Status = (Status)row["Status"],
                    Priority = (Priority)row["Priority"],
                    Developer = new Developer() { Id = (int)row["DeveloperId"] },
                    Project = new Project() { Id = (int)row["ProjectId"] },
                });
            }
            ds.Dispose();
            return tasks;
        }
    }
}
