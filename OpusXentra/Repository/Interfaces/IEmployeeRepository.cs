using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<Employee> FirstOrDefault(Expression<Func<Employee, bool>> predicate);

        Task<int> Add(Employee entity);
        Task<int> Update(Employee entity);
        Task Remove(Employee entity);

        Task<IEnumerable<Employee>> GetAll();
        Task<IEnumerable<Employee>> GetWhere(Expression<Func<Employee, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<Employee, bool>> predicate);
    }
}
