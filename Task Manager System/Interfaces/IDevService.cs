using System.Collections.Generic;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace Task_Manager_System.Interfaces
{
    public interface IDevService
    {
        Task<Developer> GetDeveloperById(int id);
        Task<Developer> GetDeveloperByName(string name);
        Task<List<Developer>> GetAll();
    }
}
