using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Models
{
    internal class AppDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                 .HasOne(e => e.Manager)
                 .WithMany(e => e.Employees)
                 .HasForeignKey(e => e.ManagerId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            

            optionsBuilder.UseSqlServer("server =LAPTOP-KILED23V\\SQLEXPRESS; Database =DI; User ID =sa; password =9121685836; TrustServerCertificate=True;");
        }
    }
}
