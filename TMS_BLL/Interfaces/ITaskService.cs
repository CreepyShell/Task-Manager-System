using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
{
    public interface ITaskService : IBasicInterface<Models.Task>
    {
        Task<bool> AddTaskToProject(Models.Task newTask);
        Task<Models.Task> UpdateTask(string idUpdatedTask, Models.Task updatedTask);
        Task<bool> RemoveTaskFromProject(Models.Task task);
        Task<bool> AssignDeveloperToTask(string taskId, string devId);
        Task<bool> RemoveDeveloperToTask(string taskId, string devId);
        Task<bool> CompleteTask(Models.Task task);
    }
}
