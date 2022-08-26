using Microsoft.AspNetCore.Mvc;
using OnlineSinav.BLL.Services;
using OnlineSinav.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSinav.Web.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IStudentService _studentService;

        public GroupsController(IGroupService groupService, IStudentService studentService)
        {
            _groupService = groupService;
            _studentService = studentService;
        }

        public IActionResult Index(int pageNumber=1,int pageSize=10)
        {
            return View(_groupService.GetAllGroups(pageNumber,pageSize));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(GroupViewModel groupViewModel)
        {
            if (ModelState.IsValid)
            {
                groupViewModel.UsersID = 1;
                await _groupService.AddGroupAsync(groupViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(groupViewModel);
        }
        public IActionResult Details(string groupID)
        {
            var model = _groupService.GetById(Convert.ToInt32(groupID));
            model.StudentCheckList = _studentService.GetAllStudents().Select(
                a => new StudentCheckBoxListViewModel()
                {
                    ID = a.ID,
                    Name = a.Name,
                    Selected=a.GroupsID ==Convert.ToInt32(groupID)
                }).ToList();
            return View(model);
        }
        [HttpPost]  
        public IActionResult Details(GroupViewModel groupViewModel)
        {
            bool result = _studentService.SetGroupIDToStudents(groupViewModel);
            if (result)
            {
                return RedirectToAction("Details", new { groupID = groupViewModel.ID });
            }
            return View(groupViewModel);
        }
    }
}
