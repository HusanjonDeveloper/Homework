using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeWorks.Migrations
{
    /// <inheritdoc />
    public partial class People : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    PassportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.PassportId);
                    table.ForeignKey(
                        name: "FK_Passport_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 44, "Test1" },
                    { 2, 34, "Test" },
                    { 3, 23, "Test" },
                    { 4, 19, "Test" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "BirtDate",
                value: new DateTime(2024, 3, 21, 21, 42, 12, 776, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "BirtDate",
                value: new DateTime(2024, 3, 20, 21, 42, 12, 776, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "BirtDate",
                value: new DateTime(2024, 2, 21, 21, 42, 12, 776, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "BirtDate",
                value: new DateTime(2024, 1, 21, 21, 42, 12, 776, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "PassportId", "BirthDate", "FirstName", "LastName", "PersonId", "Series" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test1", "Test1", 1, "AC23214" },
                    { 2, new DateTime(1990, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2", "Test2", 2, "AD234234" },
                    { 3, new DateTime(2001, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test3", "Test3", 3, "SA2423424" },
                    { 4, new DateTime(2005, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test4", "Test4", 4, "AD837874" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passport_PersonId",
                table: "Passport",
                column: "PersonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passport");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "BirtDate",
                value: new DateTime(2024, 3, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "BirtDate",
                value: new DateTime(2024, 3, 20, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "BirtDate",
                value: new DateTime(2024, 2, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "BirtDate",
                value: new DateTime(2024, 1, 21, 21, 22, 21, 464, DateTimeKind.Local).AddTicks(9960));
        }
    }
}
