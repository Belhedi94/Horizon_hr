using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSickAndAnnualAtrrsType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("5d93cbf4-7555-42cf-ad0f-2b8c2e074e41"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("799bc15f-f023-4399-9a2a-2c793161925f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a3be82f5-f9b9-4d7b-88b7-b3e7d008713e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ae63635e-3dfb-49c4-8c94-4a0138f5420f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e5ebffbb-5e57-495d-a67e-38337ed4ebd3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f5284b3a-e365-4707-9963-e9daee276c15"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f8be0685-81aa-4bb0-868b-49748a133e36"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("fcee232d-2fec-4ad1-82fb-54903ae74d9f"));

            migrationBuilder.AlterColumn<double>(
                name: "sick",
                table: "leave_balances",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "annual",
                table: "leave_balances",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("0b360352-77bd-4a7f-89d8-13aa63e60cb5"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evacuation Day" },
                    { new Guid("1691eba7-9a9f-4219-b8c8-7160ddf5450a"), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Women's Day" },
                    { new Guid("2a1bd0e0-77e1-4d76-9f59-c1e3a1bc6d3e"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" },
                    { new Guid("3dd0c6d6-d12b-406d-be6e-de34a30738cf"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day" },
                    { new Guid("5607434f-613a-410e-ad57-f10a3b2a2663"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martyrs' Day" },
                    { new Guid("90b0a845-8c18-486e-93c9-79d0136e3ca9"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Republic Day" },
                    { new Guid("9644258c-4136-4099-a54d-f12ec3bf2558"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New year's Day" },
                    { new Guid("c3567d7d-c627-4044-bea6-18552f2c9078"), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revolution Day" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("0b360352-77bd-4a7f-89d8-13aa63e60cb5"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1691eba7-9a9f-4219-b8c8-7160ddf5450a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2a1bd0e0-77e1-4d76-9f59-c1e3a1bc6d3e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3dd0c6d6-d12b-406d-be6e-de34a30738cf"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("5607434f-613a-410e-ad57-f10a3b2a2663"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("90b0a845-8c18-486e-93c9-79d0136e3ca9"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("9644258c-4136-4099-a54d-f12ec3bf2558"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c3567d7d-c627-4044-bea6-18552f2c9078"));

            migrationBuilder.AlterColumn<int>(
                name: "sick",
                table: "leave_balances",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "annual",
                table: "leave_balances",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("5d93cbf4-7555-42cf-ad0f-2b8c2e074e41"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Republic Day" },
                    { new Guid("799bc15f-f023-4399-9a2a-2c793161925f"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martyrs' Day" },
                    { new Guid("a3be82f5-f9b9-4d7b-88b7-b3e7d008713e"), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Women's Day" },
                    { new Guid("ae63635e-3dfb-49c4-8c94-4a0138f5420f"), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revolution Day" },
                    { new Guid("e5ebffbb-5e57-495d-a67e-38337ed4ebd3"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evacuation Day" },
                    { new Guid("f5284b3a-e365-4707-9963-e9daee276c15"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day" },
                    { new Guid("f8be0685-81aa-4bb0-868b-49748a133e36"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New year's Day" },
                    { new Guid("fcee232d-2fec-4ad1-82fb-54903ae74d9f"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" }
                });
        }
    }
}
