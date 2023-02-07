using System.Collections.Generic;

namespace TMS_BLL.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Project Project { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
