using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class relationships_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "employment_details",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "ProbationPeriod",
                table: "employment_details",
                newName: "probation_period");

            migrationBuilder.RenameColumn(
                name: "JoiningDate",
                table: "employment_details",
                newName: "joining_date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "employment_details",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "EmploymentStatus",
                table: "employment_details",
                newName: "employment_status");

            migrationBuilder.RenameColumn(
                name: "EmployeeType",
                table: "employment_details",
                newName: "employee_type");

            migrationBuilder.RenameColumn(
                name: "ContractType",
                table: "employment_details",
                newName: "contract_type");

            migrationBuilder.AddColumn<Guid>(
                name: "position_id",
                table: "employment_details",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "team_id",
                table: "employment_details",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_employment_details_position_id",
                table: "employment_details",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_employment_details_team_id",
                table: "employment_details",
                column: "team_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employment_details_positions_position_id",
                table: "employment_details",
                column: "position_id",
                principalTable: "positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employment_details_teams_team_id",
                table: "employment_details",
                column: "team_id",
                principalTable: "teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employment_details_positions_position_id",
                table: "employment_details");

            migrationBuilder.DropForeignKey(
                name: "FK_employment_details_teams_team_id",
                table: "employment_details");

            migrationBuilder.DropIndex(
                name: "IX_employment_details_position_id",
                table: "employment_details");

            migrationBuilder.DropIndex(
                name: "IX_employment_details_team_id",
                table: "employment_details");

            migrationBuilder.DropColumn(
                name: "position_id",
                table: "employment_details");

            migrationBuilder.DropColumn(
                name: "team_id",
                table: "employment_details");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "employment_details",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "probation_period",
                table: "employment_details",
                newName: "ProbationPeriod");

            migrationBuilder.RenameColumn(
                name: "joining_date",
                table: "employment_details",
                newName: "JoiningDate");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "employment_details",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "employment_status",
                table: "employment_details",
                newName: "EmploymentStatus");

            migrationBuilder.RenameColumn(
                name: "employee_type",
                table: "employment_details",
                newName: "EmployeeType");

            migrationBuilder.RenameColumn(
                name: "contract_type",
                table: "employment_details",
                newName: "ContractType");
        }
    }
}
