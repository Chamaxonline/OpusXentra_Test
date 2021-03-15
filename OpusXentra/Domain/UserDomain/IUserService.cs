using SmartERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserDomain
{
    public interface IUserService
    {
        Task<int> Add(ApplicationUserModel viewmodel);
        Task<string> Update(ApplicationUserModel viewmodel);
        Task<ApplicationUserModel> Get(int Id);
        Task Delete(ApplicationUserModel viewmodel);
    }
}
