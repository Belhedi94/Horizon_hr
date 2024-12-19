using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class ReorderLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2e871f4e-e0b8-4687-a9be-deb0d6e5dd55"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3ab71d0a-b50b-4e1a-8ac9-7dbc02390532"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("3ef373a9-2f4e-4b88-a080-2f8551b50297"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("51117737-b7f8-4fcc-a35b-482c066c947e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("57a08e69-8895-4c8e-a019-112811ca2f10"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("64baedd5-3fae-4af0-81e1-299fad551bbb"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("6fb63e2e-789b-4174-9835-b3e7b0d936e4"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("785dc4b4-bd2d-4973-afd7-200ed006f9e2"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("8acf749e-320f-42ef-9c59-cafbd73a9bb6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("a7d4cac5-c940-4c88-b9bb-abf51721005b"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c3ee442e-4aa9-4d35-a63a-ad5619ec5487"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("facbe0fc-a7f8-4ad9-8500-c3c6189bc554"));

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "leave_requests",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "leave_requests",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "leave_requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_date",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "reason",
                table: "leave_requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<bool>(
                name: "is_half_day",
                table: "leave_requests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "leave_requests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<float>(
                name: "days_taken",
                table: "leave_requests",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real")
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "leave_requests",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "created_at", "description", "end_date", "start_date", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("020a72f6-a9b4-4888-bcc4-4a14fa8e7be6"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3412), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3412) },
                    { new Guid("2318c4f1-9b09-4c9f-8166-82dca339b115"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3383), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3383) },
                    { new Guid("2c815c2d-bf1e-4bb1-a362-6dd9b1bb4fce"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3414), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3414) },
                    { new Guid("54c2eaeb-ef16-402a-911d-be06fb72a01a"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3387), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3388) },
                    { new Guid("612002d0-85ee-4b55-84b5-e7e357fd4273"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3352), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3352) },
                    { new Guid("6c585894-b27b-4e99-b375-55a937137520"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3393), "Revolution Day", null, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3393) },
                    { new Guid("7dafc947-fddd-4cb9-b2d0-77f94815a0bd"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3389), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3389) },
                    { new Guid("7fd03df6-c50f-44a4-b33b-18c0c80d965f"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3391), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3391) },
                    { new Guid("9d5409fd-7a18-4f50-98d2-6838ed40abe3"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3408), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3408) },
                    { new Guid("e701b9e7-4662-4b58-ac8c-867e99520214"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3310), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3326) },
                    { new Guid("fcb5755d-daf9-4f33-bab1-bd2ddc2e696d"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3410), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3410) },
                    { new Guid("fe33b16d-3335-42aa-ac2f-202c0370f4a7"), new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3385), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 18, 10, 26, 21, 266, DateTimeKind.Local).AddTicks(3386) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("020a72f6-a9b4-4888-bcc4-4a14fa8e7be6"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2318c4f1-9b09-4c9f-8166-82dca339b115"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("2c815c2d-bf1e-4bb1-a362-6dd9b1bb4fce"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("54c2eaeb-ef16-402a-911d-be06fb72a01a"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("612002d0-85ee-4b55-84b5-e7e357fd4273"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("6c585894-b27b-4e99-b375-55a937137520"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("7dafc947-fddd-4cb9-b2d0-77f94815a0bd"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("7fd03df6-c50f-44a4-b33b-18c0c80d965f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("9d5409fd-7a18-4f50-98d2-6838ed40abe3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("e701b9e7-4662-4b58-ac8c-867e99520214"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("fcb5755d-daf9-4f33-bab1-bd2ddc2e696d"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("fe33b16d-3335-42aa-ac2f-202c0370f4a7"));

            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "leave_requests",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 11);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "leave_requests",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "leave_requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_date",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "reason",
                table: "leave_requests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<bool>(
                name: "is_half_day",
                table: "leave_requests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "leave_requests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<float>(
                name: "days_taken",
                table: "leave_requests",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real")
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "leave_requests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("Relational:ColumnOrder", 10);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "leave_requests",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "created_at", "description", "end_date", "start_date", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("2e871f4e-e0b8-4687-a9be-deb0d6e5dd55"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1811), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1812) },
                    { new Guid("3ab71d0a-b50b-4e1a-8ac9-7dbc02390532"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1830), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1831) },
                    { new Guid("3ef373a9-2f4e-4b88-a080-2f8551b50297"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1813), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1814) },
                    { new Guid("51117737-b7f8-4fcc-a35b-482c066c947e"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1828), "Revolution Day", null, new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1829) },
                    { new Guid("57a08e69-8895-4c8e-a019-112811ca2f10"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1836), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1836) },
                    { new Guid("64baedd5-3fae-4af0-81e1-299fad551bbb"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1815), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1815) },
                    { new Guid("6fb63e2e-789b-4174-9835-b3e7b0d936e4"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1834), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1834) },
                    { new Guid("785dc4b4-bd2d-4973-afd7-200ed006f9e2"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1805), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1806) },
                    { new Guid("8acf749e-320f-42ef-9c59-cafbd73a9bb6"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1808), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1808) },
                    { new Guid("a7d4cac5-c940-4c88-b9bb-abf51721005b"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1809), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1810) },
                    { new Guid("c3ee442e-4aa9-4d35-a63a-ad5619ec5487"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1767), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1779) },
                    { new Guid("facbe0fc-a7f8-4ad9-8500-c3c6189bc554"), new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1832), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(2024, 12, 17, 15, 13, 55, 710, DateTimeKind.Local).AddTicks(1833) }
                });
        }
    }
}
