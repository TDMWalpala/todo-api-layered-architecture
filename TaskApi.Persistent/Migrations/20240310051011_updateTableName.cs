using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.Persistent.Migrations
{
    /// <inheritdoc />
    public partial class updateTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Auth_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auth",
                table: "Auth");

            migrationBuilder.RenameTable(
                name: "Auth",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 10, 10, 40, 11, 112, DateTimeKind.Local).AddTicks(9851), new DateTime(2024, 3, 11, 10, 40, 11, 112, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Auth");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auth",
                table: "Auth",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 9, 10, 12, 2, 789, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 3, 10, 10, 12, 2, 789, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Auth_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Auth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
