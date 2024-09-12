using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class RenderBankAccountInUsersNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_bank_account_id",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "bank_account_id",
                table: "users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_users_bank_account_id",
                table: "users",
                column: "bank_account_id",
                unique: true,
                filter: "[bank_account_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users",
                column: "bank_account_id",
                principalTable: "bank_accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_bank_account_id",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "bank_account_id",
                table: "users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_bank_account_id",
                table: "users",
                column: "bank_account_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_bank_accounts_bank_account_id",
                table: "users",
                column: "bank_account_id",
                principalTable: "bank_accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
