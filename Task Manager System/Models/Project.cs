using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_System.Models
{
    public class Project
    {
        public Task<string> Id { get; set; }
        public Task<string> Name { get; set; }
        public Task<string> Description { get; set; }
        public Task<DateTime> StartDate { get; set; }
        public Task<int> Deadline { get; set; }
        public Status Status { get; set; }
    }
}
