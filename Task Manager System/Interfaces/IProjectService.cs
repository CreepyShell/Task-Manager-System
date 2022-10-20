using System.Threading.Tasks;
using Task_Manager_System.Models;

namespace Task_Manager_System.Interfaces
{
    public interface IProjectService : IBasicInterface<Project>
    {
        Task<bool> AddProject(Project newProject);
        Task<Project> UpdateProject(string idOldProject, Project newProject);
        Task<string> ViewProjectProjectProfile(Project project);
    }
}
