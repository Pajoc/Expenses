using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpensesBE.API.Migrations
{
    public partial class SeedEmployee2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"), "Accounting" },
                    { new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"), "Design" },
                    { new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"), "IT" },
                    { new Guid("578359b7-1967-41d6-8b87-64ab7605587e"), "Production" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"),
                column: "DepartmentId",
                value: new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"),
                column: "DepartmentId",
                value: new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"),
                column: "DepartmentId",
                value: new Guid("578359b7-1967-41d6-8b87-64ab7605587e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("578359b7-1967-41d6-8b87-64ab7605587e"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"),
                column: "DepartmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"),
                column: "DepartmentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"),
                column: "DepartmentId",
                value: null);
        }
    }
}
