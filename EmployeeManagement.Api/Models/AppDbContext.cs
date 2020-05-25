using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Departments table
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 1,
                DepartmentName = "IT"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 2,
                DepartmentName = "HR"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 3,
                DepartmentName = "Finance"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 4,
                DepartmentName = "Payroll"
            });

            //seed employees table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 101,
                FirstName = "John",
                LastName = "Wick",
                DateOfBirth = new DateTime(1981, 12, 11),
                Gender = Gender.Male,
                Email = "John.wick@Testmail.com",
                DepartmentId = 1,
                PhotoPath = "images/image5.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 102,
                FirstName = "Peter",
                LastName = "Parker",
                DateOfBirth = new DateTime(1984, 09, 08),
                Gender = Gender.Male,
                Email = "peter.parker@Testmail.com",
                DepartmentId = 2,
                PhotoPath = "images/image9.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 103,
                FirstName = "Neytiri",
                LastName = "Avatar",
                DateOfBirth = new DateTime(1990, 12, 10),
                Gender = Gender.Female,
                Email = "neytiri.avatar@Testmail.com",
                DepartmentId = 3,
                PhotoPath = "images/image6.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 104,
                FirstName = "Metal Gear",
                LastName = "Solid",
                DateOfBirth = new DateTime(1991, 05, 04),
                Gender = Gender.Female,
                Email = "mgs@Testmail.com",
                DepartmentId = 4,
                PhotoPath = "images/image7.jpg"
            });
        }
    }
}
