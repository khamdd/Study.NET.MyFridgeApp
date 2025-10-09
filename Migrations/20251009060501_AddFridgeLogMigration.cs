using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFridgeApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFridgeLogMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FridgeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeLogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FridgeLogs",
                columns: new[] { "Id", "ActionDescription", "LogDate", "Status" },
                values: new object[,]
                {
                    { 1, "Remove Fish Item", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, "Add Apple", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 3, "Remove Cabbage", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FridgeLogs");
        }
    }
}
