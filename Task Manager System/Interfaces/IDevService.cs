﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TMS_BLL.Models;

namespace Task_Manager_System.Interfaces
{
    public interface IDevService
    {
        Task<Developer> GetDeveloperById(int id);
        Task<Developer> GetDeveloperWithProject(int devId);
        Task<Developer> GetDeveloperByLastName(string name);
        Task<List<Developer>> GetAll();
    }
}
