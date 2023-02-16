using Oracle.ManagedDataAccess.Client;
using System.Threading.Tasks;
using TMS_BLL.Interfaces;

namespace Task_Manager_System.Services
{
    public class TaskService : ITaskService
    {
        public async Task<bool> AddTaskToProject(TMS_BLL.Models.Task newTask)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();
                string sqlQuery = "INSERT INTO TASKS (TaskId, Name, Description, StartDate, Hours, Status, Priority, ProjectId, DeveloperId) " +
                    $"VALUES ({newTask.Id}, '{newTask.Name}', '{newTask.Description}', TO_DATE('{newTask.StartDate.ToString("dd/MM/yyyy")}','DD/MM/YYYY'), {newTask.Hours}, '{newTask.Status}', '{newTask.Priority}', {newTask.Project.Id}, {newTask.Developer.Id})";

                OracleCommand command = new OracleCommand(sqlQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                return true;
            }
        }

        public Task<bool> AssignDeveloperToTask(string taskId, string devId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CompleteTask(TMS_BLL.Models.Task task)
        {
            throw new System.NotImplementedException();
        }

        public Task<TMS_BLL.Models.Task> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TMS_BLL.Models.Task> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveDeveloperToTask(string taskId, string devId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveTaskFromProject(TMS_BLL.Models.Task task)
        {
            throw new System.NotImplementedException();
        }

        public Task<TMS_BLL.Models.Task> UpdateTask(string idUpdatedTask, TMS_BLL.Models.Task updatedTask)
        {
            throw new System.NotImplementedException();
        }
    }
}
