using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFridgeApp.Migrations
{
    /// <inheritdoc />
    public partial class FixedAddInitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 11, 13, 58, 37, 778, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 10, 4, 13, 58, 37, 777, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 10, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(456), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(460), new DateTime(2025, 10, 3, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 8, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 16, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(509), new DateTime(2025, 10, 1, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(513), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 13, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 18, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(519), new DateTime(2025, 10, 3, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 11, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(536), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 12, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 10, 2, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 18, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(546), new DateTime(2025, 9, 30, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 16, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 10, 4, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 13, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 10, 1, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 10, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(576), new DateTime(2025, 9, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2027, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(580), new DateTime(2025, 8, 7, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 9, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(583), new DateTime(2025, 10, 5, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 8, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(586), new DateTime(2025, 10, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2025, 10, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(589), new DateTime(2025, 9, 26, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExpiryDate", "ImportDate" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(592), new DateTime(2025, 9, 21, 13, 58, 37, 779, DateTimeKind.Local).AddTicks(591) });
        }
    }
}
