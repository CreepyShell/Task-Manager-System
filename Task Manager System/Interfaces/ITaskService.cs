using System.Collections.Generic;
using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface ITaskService : IBasicInterface<Models.Task>
    {
        Task<bool> AddTaskToProject(Models.Task newTask);
        Task<Models.Task> UpdateTask(int idUpdatedTask, Models.Task updatedTask);
        Task<bool> RemoveTaskFromProject(int task);
        Task<bool> AssignDeveloperToTask(int taskId, int devId);
        Task<bool> RemoveDeveloperFromTask(int taskId, int devId);
        Task<bool> CompleteTask(int task);
        Task<List<Models.Task>> GetUnassignedAndUnfinishedTasks();
        Task<List<Models.Task>> GetAllProjectTasks(int projId);
        Task<List<Models.Task>> GetDeveloperTasks(int devId);
    }
}
