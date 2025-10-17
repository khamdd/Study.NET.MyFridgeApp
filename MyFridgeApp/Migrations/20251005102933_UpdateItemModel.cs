using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFridgeApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusChangedAt",
                table: "Items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StatusChangedAt",
                table: "Items",
                type: "datetime2",
                nullable: true);
        }
    }
}
