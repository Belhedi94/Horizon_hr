using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePublicHolidayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "PublicHolidays",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PublicHolidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "PublicHolidays",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PublicHolidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "PublicHolidays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "CreatedAt", "Description", "EndDate", "StartDate", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4631559c-5606-438f-aae1-f8a084825762"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1955), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64b35dbe-f897-472e-aaa2-dc992df49367"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1941), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66c92852-2690-4227-835a-5f37b12a29b7"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1936), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bef03ea-3f95-42d4-b84c-27736d1e8848"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1960), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f30b9f4-e94b-489d-82fb-833dc165c05b"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1957), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab847a6e-d2f2-427b-aed3-3187540833fe"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1952), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ada64c36-f792-428d-9a3d-815c54449f97"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1938), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4960334-ef3e-4c10-8c9c-10e9823b9a8c"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1959), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca5179c1-e1ef-471b-bca9-4425fda7c494"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1940), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e98daa56-bb55-4ef9-95d8-71b5a3327d8e"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1897), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9af9753-3fce-4227-a17b-6de21ff3c4a6"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1962), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea225ed3-ec24-4472-8bac-ac5efa9226ee"), new DateTime(2024, 10, 7, 7, 26, 31, 508, DateTimeKind.Local).AddTicks(1953), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4631559c-5606-438f-aae1-f8a084825762"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("64b35dbe-f897-472e-aaa2-dc992df49367"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("66c92852-2690-4227-835a-5f37b12a29b7"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("7bef03ea-3f95-42d4-b84c-27736d1e8848"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8f30b9f4-e94b-489d-82fb-833dc165c05b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ab847a6e-d2f2-427b-aed3-3187540833fe"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ada64c36-f792-428d-9a3d-815c54449f97"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c4960334-ef3e-4c10-8c9c-10e9823b9a8c"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ca5179c1-e1ef-471b-bca9-4425fda7c494"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e98daa56-bb55-4ef9-95d8-71b5a3327d8e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e9af9753-3fce-4227-a17b-6de21ff3c4a6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ea225ed3-ec24-4472-8bac-ac5efa9226ee"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PublicHolidays");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PublicHolidays");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PublicHolidays");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PublicHolidays");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "PublicHolidays",
                newName: "Date");

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
    }
}
