using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpensesBE.API.Migrations
{
    public partial class SeedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Code", "DepartmentId", "IsActive", "MainEmail", "Name", "Treshold" },
                values: new object[,]
                {
                    { new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"), "ABA", null, true, "antonio.barbosa@beaudrey.pt", "António Barbosa", 250000m },
                    { new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"), "RAN", null, false, "ricardo.antunes@beaudrey.pt", "Ricardo Antunes", 150000m },
                    { new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"), "PCR", null, false, "paula.correia@beaudrey.pt", "Paula Correia", 150000m },
                    { new Guid("60188a2b-2784-4fc4-8df8-8919ff838b0b"), "LSI", null, false, "luis.silva@beaudrey.pt", "Luis Silva", 150000m },
                    { new Guid("76053df4-6687-4353-8937-b45556748abe"), "GMA", null, false, "gil.martins@beaudrey.pt", "Gil Martins", 150000m },
                    { new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"), "VCR", null, false, "vitor.correia@beaudrey.pt", "Vitor Correia", 150000m },
                    { new Guid("bc4c35c3-3857-4250-9449-155fcf5109ec"), "JCA", null, false, "joão.costa@beaudrey.pt", "João Costa", 150000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("60188a2b-2784-4fc4-8df8-8919ff838b0b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("76053df4-6687-4353-8937-b45556748abe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bc4c35c3-3857-4250-9449-155fcf5109ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"));
        }
    }
}
