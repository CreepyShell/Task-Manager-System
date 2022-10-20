using System.Threading.Tasks;
using Task_Manager_System.Models;

namespace Task_Manager_System.Interfaces
{
    public interface IDeveloperInterface : IBasicInterface<Developer>
    {
        Task<bool> AssignDeveloperToProject(Developer developer, string ProjectId);
        Task<bool> AssignDeveloperToTask(Developer developer, string TaskId);
        Task<bool> RemoveDeveloperFromProject(Developer developer, string ProjectId);
        Task<bool> RemoveDeveloperFromTask(Developer developer, string TaskId);
        Task<bool> CompleteProject(Project project);
        Task<bool> CompleteTask(Models.Task task);
    }
}
