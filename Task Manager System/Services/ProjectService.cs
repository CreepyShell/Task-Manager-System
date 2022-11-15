using System.Threading.Tasks;
using TMS_BLL.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class ProjectService : IProjectService
    {
        public Task<bool> AddProject(Project newProject)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AssignDeveloperToProject(string projId, string devId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CompleteProject(Project project)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> UpdateProject(string idOldProject, Project newProject)
        {
            throw new System.NotImplementedException();
        }
    }
}
