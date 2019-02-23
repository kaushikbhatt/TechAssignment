using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssignment.Entities.Model;

namespace TechnicalAssignment.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
           
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KAUSHIK\\SQLEXPRESS;Database=TechnicalAssignment;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
