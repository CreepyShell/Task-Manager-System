using System;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace TMS_BLL.Interfaces
{
    public interface IAdminInterface : IBasicInterface<Developer>
    {
        Task<string> ShowProjectProfile(Project project);
        Task<string> ShowProjectProfile(Developer developer);
        Task<bool> ShowMonthRevenue(DateTime startDate, DateTime endDate);
    }
}
