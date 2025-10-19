using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFridgeApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "All kinds of meat products", "Meat" },
                    { 2, "Fish, prawns, and other seafood", "Seafood" },
                    { 3, "Fresh fruits", "Fruit" },
                    { 4, "Fresh vegetables", "Vegetable" },
                    { 5, "Milk, cheese, yogurt, and dairy products", "Dairy" },
                    { 6, "All types of eggs", "Eggs" },
                    { 7, "Juices, soft drinks, and other beverages", "Drinks" },
                    { 8, "Sauces, condiments, and dressings", "Sauces" },
                    { 9, "Bread, cakes, and other baked goods", "Bakery" },
                    { 10, "Items not covered by other categories", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "ExpiryDate", "ImportDate", "Name", "Notes", "Quantity", "Status", "Unit" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 10, 11, 13, 58, 37, 778, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 10, 4, 13, 58, 37, 777, DateTimeKind.Local).AddTicks(5136), "Beef Steak", "Grass-fed beef", 2, 0, "kg" },
                    { 2, 1, new DateTime(2025, 10, 10, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(456), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(452), "Pork Chops", "", 6, 0, "pieces" },
                    { 3, 2, new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 10, 3, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(459), "Salmon Fillet", "Fresh Atlantic salmon", 1, 0, "kg" },
                    { 4, 2, new DateTime(2025, 10, 8, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(463), "Prawns", "Frozen prawns", 500, 0, "g" },
                    { 5, 3, new DateTime(2025, 10, 16, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 10, 1, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(508), "Apples", "", 6, 0, "pieces" },
                    { 6, 3, new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(513), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(512), "Bananas", "Ripe", 4, 0, "pieces" },
                    { 7, 3, new DateTime(2025, 10, 13, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(515), "Grapes", "Seedless", 1, 0, "kg" },
                    { 8, 4, new DateTime(2025, 10, 18, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(519), new DateTime(2025, 10, 3, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(518), "Carrots", "", 1, 0, "kg" },
                    { 9, 4, new DateTime(2025, 10, 11, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(536), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(535), "Broccoli", "Organic", 2, 0, "pieces" },
                    { 10, 5, new DateTime(2025, 10, 12, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(538), "Milk", "Low-fat", 2, 0, "liters" },
                    { 11, 5, new DateTime(2025, 10, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 10, 2, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(541), "Cheddar Cheese", "Block", 200, 0, "g" },
                    { 12, 6, new DateTime(2025, 10, 18, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(546), new DateTime(2025, 9, 30, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(545), "Chicken Eggs", "Free-range", 12, 0, "pieces" },
                    { 13, 6, new DateTime(2025, 10, 16, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(547), "Duck Eggs", "", 6, 0, "pieces" },
                    { 14, 7, new DateTime(2025, 10, 13, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(551), "Orange Juice", "Freshly squeezed", 1, 0, "liter" },
                    { 15, 7, new DateTime(2026, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 10, 1, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(554), "Coca-Cola", "", 6, 0, "cans" },
                    { 16, 8, new DateTime(2026, 10, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(576), new DateTime(2025, 9, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(575), "Tomato Ketchup", "Big size", 1, 0, "bottle" },
                    { 17, 8, new DateTime(2027, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(580), new DateTime(2025, 8, 7, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(579), "Soy Sauce", "Japanese style", 1, 0, "bottle" },
                    { 18, 9, new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(583), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(582), "Whole Wheat Bread", "", 1, 0, "loaf" },
                    { 19, 9, new DateTime(2025, 10, 8, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(586), new DateTime(2025, 10, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(585), "Chocolate Cake", "Birthday cake", 1, 0, "piece" },
                    { 20, 10, new DateTime(2025, 10, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(589), new DateTime(2025, 9, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(588), "Butter", "Salted", 250, 0, "g" },
                    { 21, 10, new DateTime(2026, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(592), new DateTime(2025, 9, 21, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(591), "Pickles", "Homemade", 1, 0, "jar" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
