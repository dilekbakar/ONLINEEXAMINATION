using OnlineSinav.Data.Model;
using OnlineSinav.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSinav.BLL.Services
{
    public interface IStudentService
    {
        PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize);
        Task<StudentViewModel> AddAsync(StudentViewModel vm);
        IEnumerable<Students> GetAllStudents();
        bool SetGroupIDToStudents(GroupViewModel vm);
        bool SetExamResult(AttendExamViewModel vm);
        IEnumerable<ResultViewModel> GetExamResult(int studentID);    
        StudentViewModel GetStudentDetails(int studentID);  
        Task<StudentViewModel> UpdateAsync(StudentViewModel vm);   
    }
}
