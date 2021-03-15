using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> GetById(int id);
        Task<Company> FirstOrDefault(Expression<Func<Company, bool>> predicate);

        Task<int> Add(Company entity);
        Task<int> Update(Company entity);
        Task Remove(Company entity);

        Task<IEnumerable<Company>> GetAll();
        Task<IEnumerable<Company>> GetWhere(Expression<Func<Company, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<Company, bool>> predicate);
    }
}
