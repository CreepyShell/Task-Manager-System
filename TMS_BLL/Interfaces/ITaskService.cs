using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface ITaskService : IBasicInterface<Models.Task>
    {
        Task<bool> AddTaskToProject(Models.Task newTask);
        Task<Models.Task> UpdateTask(string idUpdatedTask, Models.Task updatedTask);
        Task<bool> RemoveTaskFromProject(Models.Task task);
    }
}
