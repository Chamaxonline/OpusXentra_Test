using Entity.Models;
using EntityLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UserRepository: IUserRepository
    {
        private readonly OpusDbContext _context;
        public UserRepository(OpusDbContext context)
        {
            _context = context;
        }

        public Task<int> Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> FirstOrDefault(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetWhere(Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task Remove(ApplicationUser entity)
        {
            _context.Set<ApplicationUser>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Update(ApplicationUser entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
