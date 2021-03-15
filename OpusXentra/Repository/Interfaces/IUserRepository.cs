using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
   public interface IUserRepository
    {
        Task<ApplicationUser> GetById(int id);
        Task<Employee> FirstOrDefault(Expression<Func<ApplicationUser, bool>> predicate);

        Task<int> Add(ApplicationUser entity);
        Task<string> Update(ApplicationUser entity);
        Task Remove(ApplicationUser entity);

        Task<IEnumerable<ApplicationUser>> GetAll();
        Task<IEnumerable<ApplicationUser>> GetWhere(Expression<Func<ApplicationUser, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<Employee, bool>> predicate);
    }
}
