using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskApi.Persistent.Migrations
{
    /// <inheritdoc />
    public partial class AuthorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Auth",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tharindu" },
                    { 2, "Pasan" },
                    { 3, "Namal" },
                    { 4, "Kamal" },
                    { 5, "Ruwan" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 3, 9, 10, 12, 2, 789, DateTimeKind.Local).AddTicks(9450), new DateTime(2024, 3, 10, 10, 12, 2, 789, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Auth_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Auth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Auth_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Auth");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 7, 19, 15, 56, 614, DateTimeKind.Local).AddTicks(7582), new DateTime(2024, 3, 8, 19, 15, 56, 614, DateTimeKind.Local).AddTicks(7598) });
        }
    }
}
