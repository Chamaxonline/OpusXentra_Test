using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CompanyDomain
{
    public interface ICompanyService
    {
        Task<int> Add(CompanyViewModel viewmodel);
        Task<int> Update(CompanyViewModel viewmodel);
        Task<CompanyViewModel> Get(int Id);
        void Delete(CompanyViewModel viewmodel);
    }
}
