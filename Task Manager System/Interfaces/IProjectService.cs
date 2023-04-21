using System.Collections.Generic;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
{
    public interface IProjectService : IBasicInterface<Project>
    {
        /// <summary>
        /// Add a project to the system
        /// </summary>
        /// <param name="newProject">Project to add</param>
        /// <returns>true, if added successfully</returns>
        Task<bool> AddProject(Project newProject);
        /// <summary>
        /// Update a project in the system
        /// </summary>
        /// <param name="idOldProject">Id of project to be updated</param>
        /// <param name="newProject">Updated project details</param>
        /// <returns>Updated project</returns>
        Task<Project> UpdateProject(int idOldProject, Project newProject);
        /// <summary>
        /// Complete a project and remove all developers from it
        /// </summary>
        /// <param name="projectId">Id of a project to be removed</param>
        /// <returns>True if project updated succsessfully, false if deadline is expired</returns>
        Task<bool> CompleteProject(int projectId);
        /// <summary>
        /// Assign developer to a project
        /// </summary>
        /// <param name="projId"></param>
        /// <param name="devId"></param>
        /// <returns></returns>
        Task<bool> AssignDeveloperToProject(int projId, int devId);
        /// <summary>
        /// Get all projects with unfinished status
        /// </summary>
        /// <returns></returns>
        Task<List<Project>> GetUnfinishedProject();
        /// <summary>
        /// Get project with developer
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<Project> GetProjectWithDevelopers(int projectId);
    }
}
