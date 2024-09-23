using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class CreateLeaveBalanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("0cbe0883-1c1d-41a3-83b0-cb6b407c19a9"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("0ce49648-ad69-4a9e-85da-9c39705da56a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("21e8bf45-04e4-46a0-9d3a-f0120ec989b6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("57ca2f30-4d0d-40cf-84da-d8c701360261"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("81cd297f-3bc7-4732-8e8d-31c360950e54"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8310b62d-f35b-45d0-b590-84fb2ef65216"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("d98eb67f-ae7d-4a13-98f9-a299c3a0cbd6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f004985b-b1de-45e3-af3a-ecf0c6dd7238"));

            migrationBuilder.CreateTable(
                name: "leave_balances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalLeaveDays = table.Column<int>(type: "int", nullable: false),
                    RemainingLeaveDays = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leave_balances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leave_balances_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("1bc03b70-a0b8-4613-b3e8-2f388bdc8782"), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revolution Day" },
                    { new Guid("2fc98a8a-830e-4767-ab0a-bbaad2ca7182"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Republic Day" },
                    { new Guid("6ffe0891-907c-44b4-947a-2ad55d4687ba"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" },
                    { new Guid("74d68855-4784-4cfa-bbf3-9fe5b16cbe0b"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martyrs' Day" },
                    { new Guid("8a1faaca-6ae4-463e-a030-8eabd5ce95fe"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evacuation Day" },
                    { new Guid("a1d6dbb7-9548-4bc6-91f2-5aed04dc175c"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day" },
                    { new Guid("b94cb983-c78d-447a-be1d-3fe89044ee3f"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New year's Day" },
                    { new Guid("edc32c09-5d69-4b4d-abb0-3d5f695d9c80"), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Women's Day" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_leave_balances_UserId",
                table: "leave_balances",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leave_balances");

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1bc03b70-a0b8-4613-b3e8-2f388bdc8782"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2fc98a8a-830e-4767-ab0a-bbaad2ca7182"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("6ffe0891-907c-44b4-947a-2ad55d4687ba"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("74d68855-4784-4cfa-bbf3-9fe5b16cbe0b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8a1faaca-6ae4-463e-a030-8eabd5ce95fe"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a1d6dbb7-9548-4bc6-91f2-5aed04dc175c"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("b94cb983-c78d-447a-be1d-3fe89044ee3f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("edc32c09-5d69-4b4d-abb0-3d5f695d9c80"));

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { new Guid("0cbe0883-1c1d-41a3-83b0-cb6b407c19a9"), new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evacuation Day" },
                    { new Guid("0ce49648-ad69-4a9e-85da-9c39705da56a"), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" },
                    { new Guid("21e8bf45-04e4-46a0-9d3a-f0120ec989b6"), new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martyrs' Day" },
                    { new Guid("57ca2f30-4d0d-40cf-84da-d8c701360261"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Republic Day" },
                    { new Guid("81cd297f-3bc7-4732-8e8d-31c360950e54"), new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Women's Day" },
                    { new Guid("8310b62d-f35b-45d0-b590-84fb2ef65216"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New year's Day" },
                    { new Guid("d98eb67f-ae7d-4a13-98f9-a299c3a0cbd6"), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Revolution Day" },
                    { new Guid("f004985b-b1de-45e3-af3a-ecf0c6dd7238"), new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day" }
                });
        }
    }
}
