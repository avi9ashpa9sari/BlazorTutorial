using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Run(LoadEmployees);
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        #region Hardcode Employees
        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 101,
        //        FirstName = "John",
        //        LastName = "Wick",
        //        DateOfBirth = new DateTime(1981, 12, 11),
        //        Gender = Gender.Male,
        //        Email = "John.wick@Testmail.com",
        //        //Department = new Department { DepartmentId = 1, DepartmentName = "HR" },
        //        DepartmentId = 1,
        //        PhotoPath = "images/image5.jpg"
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 102,
        //        FirstName = "Peter",
        //        LastName = "Parker",
        //        DateOfBirth = new DateTime(1984, 09, 08),
        //        Gender = Gender.Male,
        //        Email = "peter.parker@Testmail.com",
        //        DepartmentId = 2,
        //        PhotoPath = "images/image9.jpg"
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 103,
        //        FirstName = "Neytiri",
        //        LastName = "Avatar",
        //        DateOfBirth = new DateTime(1990, 12, 10),
        //        Gender = Gender.Female,
        //        Email = "neytiri.avatar@Testmail.com",
        //        DepartmentId = 3,
        //        PhotoPath = "images/image6.jpg"
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 104,
        //        FirstName = "Metal Gear",
        //        LastName = "Solid",
        //        DateOfBirth = new DateTime(1991, 05, 04),
        //        Gender = Gender.Female,
        //        Email = "mgs@Testmail.com",
        //        DepartmentId = 4,
        //        PhotoPath = "images/image7.jpg"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4 };
        //}
        #endregion
    }
}
