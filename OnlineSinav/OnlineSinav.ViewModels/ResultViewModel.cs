using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.ViewModels
{
    public class ResultViewModel
    {
        public int StudentID { get; set; }
        public string ExamName { get; set; }
        public int TotalQuestion { get; set; }
        public int CorrectAnswer { get; set; }
        public int WrongAnswer { get; set; }
    }
}
