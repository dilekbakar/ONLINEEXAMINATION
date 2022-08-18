using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.ViewModels
{
    public class AttendExamViewModel
    {
        public int StudentID { get; set; }
        public string ExamName { get; set; }
        public List<QnAsViewModel> QnAs {get; set; }
        public string Message { get; set; }
    }
}
