using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class EditDescriptionLengthForManyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "positions",
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
                    { new Guid("038d09d5-0a78-4178-ab3f-8712d461f99b"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6159), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15915c36-a40e-406b-81bb-34feb375f757"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6233), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15ca31dc-cfb0-4f30-9b07-a927d7739fa0"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6227), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23697361-33fd-4f83-a219-808fbd5d2cff"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6161), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4445116c-47b7-431a-927e-1a2bd92d7848"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6162), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85e58a21-821c-4a92-97fc-e919bd66e88b"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6225), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0854a09-c7b5-4bb3-aefe-21e51829d606"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6147), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae4e197b-c2c5-4ef8-9242-cfbeab0bd1c0"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6234), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c36e3263-2bd2-43a2-8d33-ae2d58946f0f"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6228), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e82890b4-78db-43b1-850e-7567116b44e0"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6221), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4fc72e4-7703-42d2-bd26-f1568f1bd382"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6224), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f68a585f-0d30-4241-b943-0688e411ab93"), new DateTime(2024, 10, 30, 16, 32, 48, 158, DateTimeKind.Local).AddTicks(6105), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("038d09d5-0a78-4178-ab3f-8712d461f99b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("15915c36-a40e-406b-81bb-34feb375f757"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("15ca31dc-cfb0-4f30-9b07-a927d7739fa0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("23697361-33fd-4f83-a219-808fbd5d2cff"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4445116c-47b7-431a-927e-1a2bd92d7848"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("85e58a21-821c-4a92-97fc-e919bd66e88b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a0854a09-c7b5-4bb3-aefe-21e51829d606"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ae4e197b-c2c5-4ef8-9242-cfbeab0bd1c0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c36e3263-2bd2-43a2-8d33-ae2d58946f0f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e82890b4-78db-43b1-850e-7567116b44e0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f4fc72e4-7703-42d2-bd26-f1568f1bd382"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f68a585f-0d30-4241-b943-0688e411ab93"));

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "teams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "positions",
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
    }
}
