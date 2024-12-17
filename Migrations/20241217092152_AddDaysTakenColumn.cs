using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AddDaysTakenColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<float>(
                name: "days_taken",
                table: "leave_requests",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "created_at", "description", "end_date", "start_date", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("06271f73-1d3c-4d63-840d-5cbe0795e090"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8899), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b214dd7-ac01-4db7-a4cd-fa39a3134ec2"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8897), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("293cfca6-5625-4cff-aeaf-f15188f7fbcc"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8902), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("348c6a29-807e-4435-af6b-b8fa62c71861"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8925), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35964afa-1a9a-4e15-9fc2-437a0414afda"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8853), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35a679f5-6781-495f-b31e-b24c1b55793f"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8895), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36fb9d0a-2866-444d-8917-43ae8466ab6e"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8928), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("460ae74b-864d-4742-9c78-2b61a77e6bb0"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8905), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f1cf2f6-4f9f-48f2-92f6-397113e53fb3"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8926), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc8b3b7f-0c03-45fe-b84c-2439549fba92"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8900), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6a690b1-2e1d-4d7a-a4e7-e966bd1522bf"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8923), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0f6fe09-2784-48c7-b22b-57e3005182c9"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8904), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("06271f73-1d3c-4d63-840d-5cbe0795e090"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1b214dd7-ac01-4db7-a4cd-fa39a3134ec2"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("293cfca6-5625-4cff-aeaf-f15188f7fbcc"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("348c6a29-807e-4435-af6b-b8fa62c71861"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("35964afa-1a9a-4e15-9fc2-437a0414afda"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("35a679f5-6781-495f-b31e-b24c1b55793f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("36fb9d0a-2866-444d-8917-43ae8466ab6e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("460ae74b-864d-4742-9c78-2b61a77e6bb0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4f1cf2f6-4f9f-48f2-92f6-397113e53fb3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("bc8b3b7f-0c03-45fe-b84c-2439549fba92"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c6a690b1-2e1d-4d7a-a4e7-e966bd1522bf"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f0f6fe09-2784-48c7-b22b-57e3005182c9"));

            migrationBuilder.DropColumn(
                name: "days_taken",
                table: "leave_requests");

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
    }
}
