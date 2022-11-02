using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface IBasicInterface<T>
        where T: class
    {
        Task<T> GetById(string id);
        Task<T> GetByName(string name);
    }
}
