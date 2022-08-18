using OnlineSinav.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.BLL.Services
{
    public interface IAccountService
    {
        LoginViewModel Login(LoginViewModel vm);
        bool AddTeacher(UserViewModel vm);
        PagedResult<UserViewModel> GetAllTeacher(int pageNumber, int pageSize);    
    }
}
