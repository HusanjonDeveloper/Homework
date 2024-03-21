using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeWorks.Migrations
{
    /// <inheritdoc />
    public partial class Students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "BirtDate", "City", "Cours", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Test1", new DateTime(2024, 3, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9864), "Test1", "Test1", "Test1", "Test1" },
                    { 2, "Test2", new DateTime(2024, 3, 20, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9938), "Test2", "Test2", "Test2", "Test2" },
                    { 3, "Test3", new DateTime(2024, 2, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9955), "Test3", "Test3", "Test3", "Test3" },
                    { 4, "Test4", new DateTime(2024, 1, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9960), "Test4", "Test4", "Test4", "Test4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
