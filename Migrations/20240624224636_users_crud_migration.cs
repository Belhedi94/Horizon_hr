using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class users_crud_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employment_details_users_UserId",
                table: "employment_details");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "employment_details",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_employment_details_UserId",
                table: "employment_details",
                newName: "IX_employment_details_user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employment_details_users_user_id",
                table: "employment_details",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employment_details_users_user_id",
                table: "employment_details");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "employment_details",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_employment_details_user_id",
                table: "employment_details",
                newName: "IX_employment_details_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_employment_details_users_UserId",
                table: "employment_details",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
