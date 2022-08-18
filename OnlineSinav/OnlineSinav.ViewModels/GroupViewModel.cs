using OnlineSinav.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace OnlineSinav.ViewModels
{
    public class GroupViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Group Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public int UsersID { get; set; }

        public List<GroupViewModel> GroupList { get; set; }
        public int TotalCount { get; set; }
        public GroupViewModel(Groups model)
        {
            ID = model.ID;
            Name = model.Name ?? "";
            Description = model.Description ?? "";
            UsersID = model.UsersID;

        }
        public Groups ContentViewModel(GroupViewModel vm)
        {
            return new Groups
            {
                ID = vm.ID,
                Name = vm.Name ?? "",
                Description = vm.Description ?? "",
                UsersID = vm.UsersID
            };
    }
}
}
