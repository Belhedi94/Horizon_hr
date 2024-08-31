using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AddLeaveBalanceAndPublicHolidays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leave_balances",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    total_leave_days = table.Column<int>(type: "int", nullable: false),
                    used_leave_days = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leave_balances", x => x.id);
                    table.ForeignKey(
                        name: "FK_leave_balances_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "public_holidays",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_public_holidays", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_leave_balances_user_id",
                table: "leave_balances",
                column: "user_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leave_balances");

            migrationBuilder.DropTable(
                name: "public_holidays");
        }
    }
}
