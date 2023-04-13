using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface ITaskService : IBasicInterface<Models.Task>
    {
        Task<bool> AddTaskToProject(Models.Task newTask);
        Task<Models.Task> UpdateTask(int idUpdatedTask, Models.Task updatedTask);
        Task<bool> RemoveTaskFromProject(Models.Task task);
        Task<bool> AssignDeveloperToTask(int taskId, int devId);
        Task<bool> RemoveDeveloperFromTask(int taskId, int devId);
        Task<bool> CompleteTask(Models.Task task);
        Task<Models.Task[]> GetUnassignedAndUnfinishedTasks(int projId);
        Task<Models.Task[]> GetAllProjectTasks(int projId);
    }
}
