using Microsoft.AspNetCore.Http;
using OnlineSinav.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace OnlineSinav.ViewModels
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {

        }
        public int ID { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Contact No")]
        public string Contact { get; set; }
        
        [Display(Name = "CV File")]
        public string CVFileName { get; set; }

        public string PictureFileName { get; set; }

        public int? GroupsID { get; set; }

        public IFormFile PictureFile { get; set; }
        public IFormFile CVFile { get; set; }
        public int TotalCount { get; set; }
        public List<StudentViewModel> StudentList { get; set; }

        public StudentViewModel(Students model)
        {
            ID= model.ID;   
            Name= model.Name ?? "";   
            UserName= model.UserName;   
            Password= model.Password;   
            Contact= model.Contact ?? "";
            CVFileName = model.CVFileName ?? "";
            PictureFileName = model.PictureFileName ?? "";
            GroupsID = model.GroupsID;
        }

        public Students ConvertViewModel(StudentViewModel vm)
        {
            return new Students
            {
                ID = vm.ID,
                Name = vm.Name ?? "",
                UserName = vm.UserName,
                Password = vm.Password,
                Contact = vm.Contact ?? "",
                CVFileName = vm.CVFileName ?? "" ,
                PictureFileName = vm.PictureFileName ?? "",
                GroupsID = vm.GroupsID
            };
        }
    }
}
