using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLeaveBalanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leave_balances_users_UserId",
                table: "leave_balances");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "leave_balances",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TotalLeaveDays",
                table: "leave_balances",
                newName: "sick");

            migrationBuilder.RenameColumn(
                name: "RemainingLeaveDays",
                table: "leave_balances",
                newName: "annual");

            migrationBuilder.RenameColumn(
                name: "LastUpdated",
                table: "leave_balances",
                newName: "updated_at");

            migrationBuilder.RenameIndex(
                name: "IX_leave_balances_UserId",
                table: "leave_balances",
                newName: "IX_leave_balances_user_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_leave_balances_users_user_id",
                table: "leave_balances",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leave_balances_users_user_id",
                table: "leave_balances");

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

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "leave_balances",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "leave_balances",
                newName: "LastUpdated");

            migrationBuilder.RenameColumn(
                name: "sick",
                table: "leave_balances",
                newName: "TotalLeaveDays");

            migrationBuilder.RenameColumn(
                name: "annual",
                table: "leave_balances",
                newName: "RemainingLeaveDays");

            migrationBuilder.RenameIndex(
                name: "IX_leave_balances_user_id",
                table: "leave_balances",
                newName: "IX_leave_balances_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_leave_balances_users_UserId",
                table: "leave_balances",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
