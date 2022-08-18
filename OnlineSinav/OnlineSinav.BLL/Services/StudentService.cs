using Microsoft.Extensions.Logging;
using OnlineSinav.Data.Model;
using OnlineSinav.Data.UnitOfWork;
using OnlineSinav.ViewModels;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ResultViewModel> GetExamResult(int studentID)
        {
            throw new NotImplementedException();
        }

        public StudentViewModel GetStudentDetails(int studentID)
        {
            throw new NotImplementedException();
        }

        public bool SetExamResult(AttendExamViewModel vm)
        {
            throw new NotImplementedException();
        }

        public bool SetGroupIDToStudents(GroupViewModel vm)
        {
            throw new NotImplementedException();
        }

        public Task<StudentViewModel> UpdateAsync(StudentViewModel vm)
        {
            throw new NotImplementedException();
        }
    }
}
