using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class Add_Team_Department_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "department_id",
                table: "teams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_teams_department_id",
                table: "teams",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_teams_departments_department_id",
                table: "teams",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teams_departments_department_id",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "IX_teams_department_id",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "teams");
        }
    }
}
