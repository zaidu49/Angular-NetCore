using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z_app.Models
{
    public class AppDataContext : DbContext
    {
        //public AppDataContext() : base("AppDatabase")
        //{ }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7EG800L\\SQLEXPRESS;Initial Catalog=AppDatabase;Integrated Security=SSPI;" + "Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId= 1, Name = "z1", Gender = "Male", Department = "IT", City = "Bournemouth" },
                new Employee { EmployeeId= 2, Name = "z2", Gender = "Male", Department = "IT", City = "Bournemouth" }
                );
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Bournemouth" },
                new City { CityId = 2, CityName = "London" }
                );
        }
    }
}
