using System.Collections.Generic;

namespace Task_Manager_System.Models
{
    public class Developer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public List<(string, int)> CompletedTasks { get; set; }
    }
}
