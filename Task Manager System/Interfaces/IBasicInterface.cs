using System.Collections.Generic;
using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface IBasicInterface<T>
        where T: class
    {
        Task<T> GetById(int id);
        Task<T> GetByName(string name);
        Task<List<T>> GetAll();
    }
}
