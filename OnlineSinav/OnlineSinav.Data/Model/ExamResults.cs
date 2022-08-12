using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.Model
{
    public class ExamResults
    {
        public int ID { get; set; }
        public int StudentsID { get; set; }
        public Students Students { get; set; }
        public int? ExamsID { get; set; }
        public Exams Exams { get; set; }
        public int QnAsID { get; set; }
        public QnAs QnAs { get; set; }
        public int Answer { get; set; }

    }
}
