using System.Collections.Generic;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace Task_Manager_System.Interfaces
{
    public interface IDevService
    {
        /// <summary>
        /// Get developer by id
        /// </summary>
        /// <param name="id">Id of a developer</param>
        /// <returns>Found developer or null</returns>
        Task<Developer> GetDeveloperById(int id);
        /// <summary>
        /// Get developer by id with project if available
        /// </summary>
        /// <param name="id">Id of a developer</param>
        /// <returns>Found developer with project or null</returns>
        Task<Developer> GetDeveloperWithProject(int devId);
        /// <summary>
        /// Get developer by name
        /// </summary>
        /// <param name="name">name of a developer</param>
        /// <returns>Found developer or null</returns>
        Task<Developer> GetDeveloperByLastName(string name);
        /// <summary>
        /// Get all developers
        /// </summary>
        /// <returns>List of developers</returns>
        Task<List<Developer>> GetAll();
    }
}
