using System.Collections.Generic;
using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface IBasicInterface<T>
        where T: class
    {
        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id">The id of entity</param>
        /// <returns>Found entity or null</returns>
        Task<T> GetById(int id);
        /// <summary>
        /// Find entity by name
        /// </summary>
        /// <param name="name">A name of entity</param>
        /// <returns>Found entity or null</returns>
        Task<T> GetByName(string name);
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        Task<List<T>> GetAll();
    }
}
