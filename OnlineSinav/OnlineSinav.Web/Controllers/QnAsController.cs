﻿using Microsoft.AspNetCore.Mvc;
using OnlineSinav.BLL.Services;
using OnlineSinav.ViewModels;
using System.Threading.Tasks;

namespace OnlineSinav.Web.Controllers
{
    public class QnAsController : Controller
    {

        private readonly IExamService _examService;
        private readonly IQnAService _qnAService;
        public QnAsController(IExamService examService, IQnAService qnAService)
        {
            _examService = examService;
            _qnAService = qnAService;
        }

        public IActionResult Index(int pageNumber=1,int pageSize=10)
        {
            return View(_qnAService.GetAll(pageNumber,pageSize));
        }
        public IActionResult Create()
        {
            var model = new QnAsViewModel();
            model.ExamList = _examService.GetAllExams();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(QnAsViewModel qnAsViewModel)
        {
            if (ModelState.IsValid)
            {
                await _qnAService.AddAsync(qnAsViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(qnAsViewModel);
        }



    }
}
