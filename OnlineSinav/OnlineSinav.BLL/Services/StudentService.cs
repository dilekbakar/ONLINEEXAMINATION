using Microsoft.Extensions.Logging;
using OnlineSinav.Data.Model;
using OnlineSinav.Data.UnitOfWork;
using OnlineSinav.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSinav.BLL.Services
{
    public class StudentService : IStudentService
    {
        IUnitOfWork _unitOfWork;
        ILogger<StudentService> _iLogger;

        public StudentService(IUnitOfWork unitOfWork, ILogger<StudentService> iLogger)
        {
            _unitOfWork = unitOfWork;
            _iLogger = iLogger;
        }

        public async Task<StudentViewModel> AddAsync(StudentViewModel vm)
        {
            try
            {
                Students obj = vm.ContentViewModel(vm);
                await _unitOfWork.GenericRepository<Students>().AddAsync(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
            return vm;
        }

        public PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize)
        {
            var model = new StudentViewModel();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<StudentViewModel> detailList = new List<StudentViewModel>();
                var modelList = _unitOfWork.GenericRepository<Students>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();
                var totalCount = _unitOfWork.GenericRepository<Students>().GetAll().ToList();
                detailList = GroupListInfo(modelList);
                if (detailList != null)
                {
                    model.StudentList = detailList;
                    model.TotalCount = totalCount.Count();

                }
            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            var result = new PagedResult<StudentViewModel>()
            {
                Data = model.StudentList,
                TotalItems = model.TotalCount,
                PageNumber = pageNumber,    
                PageSize = pageSize,

            };
            return result;
        }

        private List<StudentViewModel> GroupListInfo(List<Students> modelList)
        {
            return modelList.Select(o => new StudentViewModel(o)).ToList();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            try
            {
                var students = _unitOfWork.GenericRepository<Students>().GetAll();
                return students;
            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return Enumerable.Empty<Students>();
        }

        public IEnumerable<ResultViewModel> GetExamResult(int studentID)
        {
            try
            {
                var examResults = _unitOfWork.GenericRepository<ExamResults>().GetAll()
                    .Where(a => a.StudentsID == studentID);
                var students = _unitOfWork.GenericRepository<Students>().GetAll();
                var exams = _unitOfWork.GenericRepository<Exams>().GetAll();
                var qnas = _unitOfWork.GenericRepository<QnAs>().GetAll();

                var requiredData = examResults.Join(students, er => er.StudentsID, s => s.ID,
                    (er, st) => new { er, st }).Join(exams, erj => erj.er.ExamsID, ex => ex.ID,
                    (erj, ex) => new { erj, ex }).Join(qnas, exj => exj.erj.er.QnAsID, q => q.ID,
                    (exj, q) => new ResultViewModel()
                    {
                        StudentID = studentID,
                        ExamName = exj.ex.Title,
                        TotalQuestion = examResults.Count(a => a.StudentsID == studentID
                        && a.ExamsID == exj.ex.ID),
                        CorrectAnswer = examResults.Count(a => a.StudentsID == studentID
                        && a.ExamsID == exj.ex.ID && a.Answer == q.Answer),
                        WrongAnswer = examResults.Count(a => a.StudentsID == studentID
                        && a.ExamsID == exj.ex.ID && a.Answer != q.Answer)
                    });
                return requiredData;
            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return Enumerable.Empty<ResultViewModel>(); 
        }

        public StudentViewModel GetStudentDetails(int studentID)
        {
            try
            {
                var student = _unitOfWork.GenericRepository<Students>().GetByID(studentID);
                return student != null ? new StudentViewModel(student) : null;
            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return null;    
        }

        public bool SetExamResult(AttendExamViewModel vm)
        {
            try
            {
                foreach (var item in vm.QnAs)
                {
                    ExamResults examResults = new ExamResults();
                    examResults.StudentsID = vm.StudentID;
                    examResults.QnAsID = item.ID;
                    examResults.ExamsID = item.ExamsID;
                    examResults.Answer = item.SelectedAnswer;
                    _unitOfWork.GenericRepository<ExamResults>().AddAsync(examResults);
                }
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return false;
        }

        public bool SetGroupIDToStudents(GroupViewModel vm)
        {
            try
            {
                foreach (var item in vm.StudentCheckList)
                {
                    var student = _unitOfWork.GenericRepository<Students>().GetByID(item.ID);
                    if (item.Selected)
                    {
                        student.GroupsID = vm.ID;
                        _unitOfWork.GenericRepository<Students>().Update(student);
                    }
                    else
                    {
                        if (student.GroupsID==vm.ID)
                        {
                            student.GroupsID = null;
                        }
                    }
                    _unitOfWork.Save();
                    return true;
                }

            }
            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return false;
        }

        public async Task<StudentViewModel> UpdateAsync(StudentViewModel vm)
        {
            try
            {
                Students obj = _unitOfWork.GenericRepository<Students>().GetByID(vm.ID);
                obj.Name = vm.Name; 
                obj.UserName= vm.UserName;  
                obj.PictureFileName = vm.PictureFileName != null ? vm.PictureFileName : obj.PictureFileName;
                obj.CVFileName = vm.CVFileName != null ? vm.CVFileName : obj.CVFileName;
                obj.Contact = vm.Contact;
                await _unitOfWork.GenericRepository<Students>().UpdateAsync(obj);
            }

            catch (Exception ex)
            {

                _iLogger.LogError(ex.Message);
            }
            return vm;
        }
    }
}
