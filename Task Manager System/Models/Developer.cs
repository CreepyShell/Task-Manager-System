using System.Collections.Generic;

namespace TMS_BLL.Models
{
    public class Developer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public List<(string, int)> CompletedTasks { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
