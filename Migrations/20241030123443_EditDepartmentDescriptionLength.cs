using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class EditDepartmentDescriptionLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("04dd48cf-179c-4ef1-8488-6d3918c8f8e1"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("08ff24d2-1212-4e7c-85e9-446f0eae4d89"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("174b6938-e6f5-44d7-8fac-d56fc3bc0cc4"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("29766219-6811-4cb6-8d72-353155f17f8a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("324ca6b0-a1ba-4cfb-b4c0-c8c63f4d6d98"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("44418b80-0165-4c3b-8ca2-49750e083c3e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a7b7e333-d525-469c-b015-44ab28e5a752"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ba0caff9-aff0-4d34-89a3-305fdbb5e102"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e1319b75-85de-4d8c-a57c-c0f4daec2aa3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e47152b2-5398-4a86-a751-e482bebce54e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ebbe14a7-cc67-4595-99b7-d8a8a451513b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ed779d24-3bb0-47d6-b3ab-db04a521c91b"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "CreatedAt", "Description", "EndDate", "StartDate", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1c48b057-1b05-4949-bf6a-d901b901e1b2"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(659), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ee1e323-8504-499c-88e6-54104d4cf5d6"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(661), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29280d1a-edd3-422f-b63b-2d0d50698bc4"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(655), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32d8b176-e630-4ac0-ba4a-5cb610f88b6b"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(667), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ecdd573-3f5c-4a52-bf59-689d6e79f4be"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(653), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4dc1e4ed-2796-4af8-bd5c-a329370c2a5b"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(635), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4dde751c-86d5-45b0-8089-55bddf4c7037"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(663), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5fe3ce75-267e-4f35-98a7-68e96bb14828"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(632), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b86864c6-a2a7-492a-bc65-96936ab32cfd"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(651), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf0b0bcf-5444-40f0-9df7-f666d0155192"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(649), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1bcf4c3-9725-4d71-8f83-f33c8ca7396e"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(589), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4ae2e7a-54fa-440b-80fc-99f9826535e3"), new DateTime(2024, 10, 30, 13, 34, 42, 676, DateTimeKind.Local).AddTicks(657), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1c48b057-1b05-4949-bf6a-d901b901e1b2"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1ee1e323-8504-499c-88e6-54104d4cf5d6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("29280d1a-edd3-422f-b63b-2d0d50698bc4"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("32d8b176-e630-4ac0-ba4a-5cb610f88b6b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3ecdd573-3f5c-4a52-bf59-689d6e79f4be"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4dc1e4ed-2796-4af8-bd5c-a329370c2a5b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4dde751c-86d5-45b0-8089-55bddf4c7037"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("5fe3ce75-267e-4f35-98a7-68e96bb14828"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("b86864c6-a2a7-492a-bc65-96936ab32cfd"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("bf0b0bcf-5444-40f0-9df7-f666d0155192"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c1bcf4c3-9725-4d71-8f83-f33c8ca7396e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e4ae2e7a-54fa-440b-80fc-99f9826535e3"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "departments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "CreatedAt", "Description", "EndDate", "StartDate", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04dd48cf-179c-4ef1-8488-6d3918c8f8e1"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6006), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08ff24d2-1212-4e7c-85e9-446f0eae4d89"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6101), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("174b6938-e6f5-44d7-8fac-d56fc3bc0cc4"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6086), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29766219-6811-4cb6-8d72-353155f17f8a"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6085), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("324ca6b0-a1ba-4cfb-b4c0-c8c63f4d6d98"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6097), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44418b80-0165-4c3b-8ca2-49750e083c3e"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6093), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7b7e333-d525-469c-b015-44ab28e5a752"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6090), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba0caff9-aff0-4d34-89a3-305fdbb5e102"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6088), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1319b75-85de-4d8c-a57c-c0f4daec2aa3"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6083), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e47152b2-5398-4a86-a751-e482bebce54e"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6081), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebbe14a7-cc67-4595-99b7-d8a8a451513b"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6091), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed779d24-3bb0-47d6-b3ab-db04a521c91b"), new DateTime(2024, 10, 20, 12, 48, 26, 941, DateTimeKind.Local).AddTicks(6099), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
