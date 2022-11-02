using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
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
