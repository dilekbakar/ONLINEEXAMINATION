using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.Model
{
    public class Groups
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int UsersID { get; set; }
        public Users Users { get; set; }
        public ICollection<Students> Students { get; set; } = new HashSet<Students>(); 
        public ICollection<Exams> Exams { get; set; } = new HashSet<Exams>();
    }
}
