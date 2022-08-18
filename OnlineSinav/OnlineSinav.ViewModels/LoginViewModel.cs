using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineSinav.ViewModels
{
    public class LoginViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
