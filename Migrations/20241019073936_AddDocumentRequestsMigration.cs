using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AddDocumentRequestsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "document_requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    processed_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_document_requests_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_document_requests_user_id",
                table: "document_requests",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "document_requests");

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
    }
}
