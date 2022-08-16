using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineSinav.ViewModels
{
    public class ExamViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Time { get; set; }
        public int GroupsID { get; set; }
    }
}
