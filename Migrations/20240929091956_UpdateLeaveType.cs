using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLeaveType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("06b6eb41-27ca-4ed0-b15b-636481cec715"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("13f1e1a3-376d-487c-927d-7d072b703430"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("26c850d3-8be6-4086-8c2d-1398a872372f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2939353c-e55f-4821-a1e5-c2bcaf230845"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("464fe2ef-b9db-431f-90e9-55ba8fa964ae"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("6df0d687-b910-4ecb-82ce-e4d432b85546"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8632e332-8c15-4e6e-add7-e2053dc5eec5"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8d33752e-ebc2-46f3-8bb7-2249e7559421"));

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "leave_requests",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "type",
                table: "leave_requests",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("06b6eb41-27ca-4ed0-b15b-636481cec715"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New year's Day" },
                    { new Guid("13f1e1a3-376d-487c-927d-7d072b703430"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day" },
                    { new Guid("26c850d3-8be6-4086-8c2d-1398a872372f"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evacuation Day" },
                    { new Guid("2939353c-e55f-4821-a1e5-c2bcaf230845"), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revolution Day" },
                    { new Guid("464fe2ef-b9db-431f-90e9-55ba8fa964ae"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Republic Day" },
                    { new Guid("6df0d687-b910-4ecb-82ce-e4d432b85546"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martyrs' Day" },
                    { new Guid("8632e332-8c15-4e6e-add7-e2053dc5eec5"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" },
                    { new Guid("8d33752e-ebc2-46f3-8bb7-2249e7559421"), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Women's Day" }
                });
        }
    }
}
