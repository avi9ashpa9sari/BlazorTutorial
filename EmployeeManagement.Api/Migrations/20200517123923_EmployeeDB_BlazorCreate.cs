using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class EmployeeDB_BlazorCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Finance" },
                    { 4, "Payroll" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 101, new DateTime(1981, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John.wick@Testmail.com", "John", 0, "Wick", "images/image5.jpg" },
                    { 102, new DateTime(1984, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "peter.parker@Testmail.com", "Peter", 0, "Parker", "images/image9.jpg" },
                    { 103, new DateTime(1990, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "neytiri.avatar@Testmail.com", "Neytiri", 1, "Avatar", "images/image6.jpg" },
                    { 104, new DateTime(1991, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "mgs@Testmail.com", "Metal Gear", 1, "Solid", "images/image7.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
