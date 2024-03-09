using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.Persistent.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 3, 7, 19, 15, 56, 614, DateTimeKind.Local).AddTicks(7582), "This is task from DB", 0, "Task 1", new DateTime(2024, 3, 8, 19, 15, 56, 614, DateTimeKind.Local).AddTicks(7598) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
