using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class BankAccountMigration_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_bank_accounts_BankAccountId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "BankAccountId",
                table: "users",
                newName: "bank_account_id");

            migrationBuilder.RenameIndex(
                name: "IX_users_BankAccountId",
                table: "users",
                newName: "IX_users_bank_account_id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users",
                column: "bank_account_id",
                principalTable: "bank_accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "bank_account_id",
                table: "users",
                newName: "BankAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_users_bank_account_id",
                table: "users",
                newName: "IX_users_BankAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_bank_accounts_BankAccountId",
                table: "users",
                column: "BankAccountId",
                principalTable: "bank_accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
