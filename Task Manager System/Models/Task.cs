using System;

namespace Task_Manager_System.Models
{
    public class Task
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Hours { get; set; }
        public Status Status { get; set; }
    }
}
