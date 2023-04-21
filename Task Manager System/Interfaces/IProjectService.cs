using System.Collections.Generic;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
{
    public interface IProjectService : IBasicInterface<Project>
    {
        Task<bool> AddProject(Project newProject);
        Task<Project> UpdateProject(int idOldProject, Project newProject);
        Task<bool> CompleteProject(int projectId);
        Task<bool> AssignDeveloperToProject(int projId, int devId);
        Task<List<Project>> GetUnfinishedProject();
        Task<Project> GetProjectWithDevelopers(int projectId);
    }
}
