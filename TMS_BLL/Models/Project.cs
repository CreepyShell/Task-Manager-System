using System;
using System.Collections.Generic;

namespace TMS_BLL.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Endline { get; set; }
        public Status Status { get; set; }
        public List<Developer> Developers { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
