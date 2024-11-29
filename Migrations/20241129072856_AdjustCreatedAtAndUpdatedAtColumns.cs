using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AdjustCreatedAtAndUpdatedAtColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "PublicHolidays",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PublicHolidays",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "PublicHolidays",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "PublicHolidays",
                newName: "start_date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "PublicHolidays",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "PublicHolidays",
                newName: "created_at");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "positions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "positions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "leave_balances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "employment_details",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "employment_details",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "created_at", "description", "end_date", "start_date", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("08ab7404-503d-43de-8b1b-8e6400873b8d"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9115), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09c579d4-319a-46cb-9a24-8bb69edd5971"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9113), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1394c721-bf44-4b1c-b343-3a1ea246e2bc"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9147), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2583015d-55bb-4f89-ad04-117def55420d"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9117), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47bdd7b3-3a0b-4ed3-b831-9357739954c9"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9138), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59c1614a-5fe3-4f84-a89b-130ec7b1b0c5"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9148), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cac860b-9681-4505-8f7c-ff77dbae00f0"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9145), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("750bb312-0599-43f8-916b-b8aa085465a5"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9140), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96c6a234-891d-44d1-b022-b4f47a12e54a"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9141), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b857b1f7-07d0-4265-b3c4-0c8776c07f6d"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9075), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c556fc1f-a5f7-4214-b117-b498d8a879ba"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9143), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c983e4be-31e6-401c-ba66-f73036e0ebb6"), new DateTime(2024, 11, 29, 8, 28, 56, 478, DateTimeKind.Local).AddTicks(9136), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("08ab7404-503d-43de-8b1b-8e6400873b8d"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("09c579d4-319a-46cb-9a24-8bb69edd5971"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1394c721-bf44-4b1c-b343-3a1ea246e2bc"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2583015d-55bb-4f89-ad04-117def55420d"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("47bdd7b3-3a0b-4ed3-b831-9357739954c9"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("59c1614a-5fe3-4f84-a89b-130ec7b1b0c5"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("6cac860b-9681-4505-8f7c-ff77dbae00f0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("750bb312-0599-43f8-916b-b8aa085465a5"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("96c6a234-891d-44d1-b022-b4f47a12e54a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("b857b1f7-07d0-4265-b3c4-0c8776c07f6d"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c556fc1f-a5f7-4214-b117-b498d8a879ba"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c983e4be-31e6-401c-ba66-f73036e0ebb6"));

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "positions");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "leave_balances");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "employment_details");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "employment_details");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "PublicHolidays",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "PublicHolidays",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "PublicHolidays",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "PublicHolidays",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "PublicHolidays",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "PublicHolidays",
                newName: "CreatedAt");

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
    }
}
