using Entity.Models;
using Microsoft.EntityFrameworkCore;
using SmartERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLibrary.Context
{
    public class OpusDbContext : DbContext
    {
        public OpusDbContext(DbContextOptions<OpusDbContext> options) : base(options)
        { }
      
        public DbSet<SecurityProfile> SecurityProfile { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

    }
}
