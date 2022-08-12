using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.Model
{
    public class Exams
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Time { get; set; }
        public int GroupsID { get; set; }
        public Groups Groups { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; } = new HashSet<ExamResults>();
        public ICollection<QnAs> QnAs { get; set; } = new HashSet<QnAs>();
   


}
}
