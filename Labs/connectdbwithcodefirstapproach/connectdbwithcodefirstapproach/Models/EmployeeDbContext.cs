using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connectdbwithcodefirstapproach.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext() { }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PP0TB7N;Initial Catalog=EmployeeDB;Integrated Security=True;TrustServerCertificate=True");

    }
}
