using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.Model
{
    public class QnAs
    {
        public int ID { get; set; }
        public int ExamsID { get; set; }
        public Exams Exams { get; set; }
        public string Question { get; set; }
        public int Answer { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; } = new HashSet<ExamResults>();
    }
}
