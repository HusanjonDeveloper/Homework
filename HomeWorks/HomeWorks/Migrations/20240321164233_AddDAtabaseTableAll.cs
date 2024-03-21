using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeWorks.Migrations
{
    /// <inheritdoc />
    public partial class AddDAtabaseTableAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "BirtDate",
                value: new DateTime(2024, 3, 21, 21, 42, 32, 825, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "BirtDate",
                value: new DateTime(2024, 3, 20, 21, 42, 32, 825, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "BirtDate",
                value: new DateTime(2024, 2, 21, 21, 42, 32, 825, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "BirtDate",
                value: new DateTime(2024, 1, 21, 21, 42, 32, 825, DateTimeKind.Local).AddTicks(9676));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
