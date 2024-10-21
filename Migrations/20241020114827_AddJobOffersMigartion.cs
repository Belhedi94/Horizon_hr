using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AddJobOffersMigartion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3072343b-25df-4337-add1-a4042be4d1f3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3d93156a-1178-45d5-a4f8-caffb0b89f10"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("42cdd50e-ab47-4753-a94c-9cef80b6d8c6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4ad20934-cd0b-41b0-bade-841146eb8142"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("7a0c94a9-fd51-4685-af01-9319f5dc890c"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("9478ecef-3ba0-42c0-a6b6-dff96c501b3b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a33c4665-3300-43ab-afad-817129199dd4"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("be0a93d3-920d-4cae-801f-291729fa7048"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("ce5f0506-c3c0-4135-9d59-8ef58f2b3987"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e6a88878-5cd5-46f2-a3aa-5b6a0f3dce5a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f4bd768d-763e-4a36-bd6d-a92aecb8434d"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f4d86734-ca8f-4c59-adaa-2ac5c3945e04"));

            migrationBuilder.CreateTable(
                name: "job_offers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employment_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_offers", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "job_offers");

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

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "CreatedAt", "Description", "EndDate", "StartDate", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3072343b-25df-4337-add1-a4042be4d1f3"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8404), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d93156a-1178-45d5-a4f8-caffb0b89f10"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8421), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42cdd50e-ab47-4753-a94c-9cef80b6d8c6"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8428), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ad20934-cd0b-41b0-bade-841146eb8142"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8430), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a0c94a9-fd51-4685-af01-9319f5dc890c"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8409), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9478ecef-3ba0-42c0-a6b6-dff96c501b3b"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8356), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a33c4665-3300-43ab-afad-817129199dd4"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8408), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be0a93d3-920d-4cae-801f-291729fa7048"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8406), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce5f0506-c3c0-4135-9d59-8ef58f2b3987"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8425), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6a88878-5cd5-46f2-a3aa-5b6a0f3dce5a"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8402), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4bd768d-763e-4a36-bd6d-a92aecb8434d"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8426), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4d86734-ca8f-4c59-adaa-2ac5c3945e04"), new DateTime(2024, 10, 19, 8, 39, 36, 335, DateTimeKind.Local).AddTicks(8423), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
