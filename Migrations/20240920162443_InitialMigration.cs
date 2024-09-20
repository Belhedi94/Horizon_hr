using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bank_accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bank_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    account_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    rib = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    holder_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    personal_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    professional_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personal_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cnss_registration_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    gender = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    marital_status = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    profile_image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bank_account_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_bank_accounts_bank_account_id",
                        column: x => x.bank_account_id,
                        principalTable: "bank_accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    department_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.id);
                    table.ForeignKey(
                        name: "FK_teams_departments_department_id",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "leave_requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    type = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_half_day = table.Column<bool>(type: "bit", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leave_requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leave_requests_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employment_details",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    contract_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    joining_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    probation_period = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    employment_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    team_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    position_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employment_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_employment_details_positions_position_id",
                        column: x => x.position_id,
                        principalTable: "positions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employment_details_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employment_details_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_employment_details_position_id",
                table: "employment_details",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_employment_details_team_id",
                table: "employment_details",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_employment_details_user_id",
                table: "employment_details",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_leave_requests_user_id",
                table: "leave_requests",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_teams_department_id",
                table: "teams",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_bank_account_id",
                table: "users",
                column: "bank_account_id",
                unique: true,
                filter: "[bank_account_id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employment_details");

            migrationBuilder.DropTable(
                name: "leave_requests");

            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "bank_accounts");
        }
    }
}
