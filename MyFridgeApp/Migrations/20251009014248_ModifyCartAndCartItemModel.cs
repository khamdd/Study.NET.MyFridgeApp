using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFridgeApp.Migrations
{
    /// <inheritdoc />
    public partial class ModifyCartAndCartItemModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ItemId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "CartItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlacedAt",
                table: "Carts",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlacedAt",
                table: "Carts");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ItemId",
                table: "CartItems",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
