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
    public class CompanyRepository : ICompanyRepository
    {
        protected OpusDbContext _context;
        public CompanyRepository(OpusDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Company entity)
        {
            await _context.Set<Company>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> CountAll()
        {
            return await _context.Set<Company>().CountAsync();

        }

        public Task<int> CountWhere(Expression<Func<Company, bool>> predicate)
         => _context.Set<Company>().CountAsync(predicate);
        public Task<Company> FirstOrDefault(Expression<Func<Company, bool>> predicate)
        => _context.Set<Company>().FirstOrDefaultAsync(predicate);


        public async Task<IEnumerable<Company>> GetAll()
        {
            return await _context.Set<Company>().ToListAsync();
        }

        public async Task<Company> GetById(int id)
        {
            return await _context.Set<Company>().FindAsync(id);
        }

        public async Task<IEnumerable<Company>> GetWhere(Expression<Func<Company, bool>> predicate)
        {
            return await _context.Set<Company>().Where(predicate).ToListAsync();
        }

        public async Task Remove(Company entity)
        {
             _context.Set<Company>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> Update(Company entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity.Id;
        }


    }
}
