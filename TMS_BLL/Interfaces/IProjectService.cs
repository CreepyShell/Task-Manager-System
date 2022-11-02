using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
{
    public interface IProjectService : IBasicInterface<Project>
    {
        Task<bool> AddProject(Project newProject);
        Task<Project> UpdateProject(string idOldProject, Project newProject);
        Task<string> ViewProjectProjectProfile(Project project);
    }
}
