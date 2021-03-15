using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeDomain
{
    public interface IEmployeeService
    {
        Task<int> Add(EmployeeViewModel viewmodel);
        Task<int> Update(EmployeeViewModel viewmodel);
        Task<EmployeeViewModel> Get(int Id);
        Task Delete(EmployeeViewModel viewmodel);
    }
}
