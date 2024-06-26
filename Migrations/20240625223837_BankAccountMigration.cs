using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class BankAccountMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BankAccountId",
                table: "users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "cnss_registration_number",
                table: "users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bank_accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bank_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    account_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    iban = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    holder_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_accounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_BankAccountId",
                table: "users",
                column: "BankAccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_bank_accounts_BankAccountId",
                table: "users",
                column: "BankAccountId",
                principalTable: "bank_accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_bank_accounts_BankAccountId",
                table: "users");

            migrationBuilder.DropTable(
                name: "bank_accounts");

            migrationBuilder.DropIndex(
                name: "IX_users_BankAccountId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "cnss_registration_number",
                table: "users");
        }
    }
}
