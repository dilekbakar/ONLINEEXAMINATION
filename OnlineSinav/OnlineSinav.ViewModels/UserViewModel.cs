using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineSinav.ViewModels
{
    public class UserViewModel
    {

        public UserViewModel()
        {

        }
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
