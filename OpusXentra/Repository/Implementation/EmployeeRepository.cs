using Entity.Models;
using EntityLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly OpusDbContext _context;
        public EmployeeRepository(OpusDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Employee entity)
        {
            await _context.Set<Employee>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> CountAll()
        {
            return await _context.Set<Employee>().CountAsync();

        }

        public Task<int> CountWhere(Expression<Func<Employee, bool>> predicate)
         => _context.Set<Employee>().CountAsync(predicate);
        public Task<Employee> FirstOrDefault(Expression<Func<Employee, bool>> predicate)
        => _context.Set<Employee>().FirstOrDefaultAsync(predicate);


        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Set<Employee>().ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Set<Employee>().FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetWhere(Expression<Func<Employee, bool>> predicate)
        {
            return await _context.Set<Employee>().Where(predicate).ToListAsync();
        }

        public async Task Remove(Employee entity)
        {
            _context.Set<Employee>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> Update(Employee entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity.Id;
        }

    }
}
