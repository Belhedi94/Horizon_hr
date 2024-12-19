using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Horizon_HR.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultTimeToUpdatedAtColumnPublicHoliday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("06271f73-1d3c-4d63-840d-5cbe0795e090"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("1b214dd7-ac01-4db7-a4cd-fa39a3134ec2"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("293cfca6-5625-4cff-aeaf-f15188f7fbcc"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("348c6a29-807e-4435-af6b-b8fa62c71861"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("35964afa-1a9a-4e15-9fc2-437a0414afda"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("35a679f5-6781-495f-b31e-b24c1b55793f"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("36fb9d0a-2866-444d-8917-43ae8466ab6e"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("460ae74b-864d-4742-9c78-2b61a77e6bb0"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("4f1cf2f6-4f9f-48f2-92f6-397113e53fb3"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("bc8b3b7f-0c03-45fe-b84c-2439549fba92"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("c6a690b1-2e1d-4d7a-a4e7-e966bd1522bf"));

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: new Guid("f0f6fe09-2784-48c7-b22b-57e3005182c9"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "created_at", "description", "end_date", "start_date", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("06271f73-1d3c-4d63-840d-5cbe0795e090"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8899), "Labour Day", null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b214dd7-ac01-4db7-a4cd-fa39a3134ec2"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8897), "Martyrs' Day", null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("293cfca6-5625-4cff-aeaf-f15188f7fbcc"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8902), "Women's Day", null, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("348c6a29-807e-4435-af6b-b8fa62c71861"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8925), "Eid al-Fitr", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35964afa-1a9a-4e15-9fc2-437a0414afda"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8853), "New year's Day", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35a679f5-6781-495f-b31e-b24c1b55793f"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8895), "Independence Day", null, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36fb9d0a-2866-444d-8917-43ae8466ab6e"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8928), "Mawlid al-Nabi", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("460ae74b-864d-4742-9c78-2b61a77e6bb0"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8905), "Revolution Day", null, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f1cf2f6-4f9f-48f2-92f6-397113e53fb3"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8926), "Islamic New Year", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unpaid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc8b3b7f-0c03-45fe-b84c-2439549fba92"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8900), "Republic Day", null, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6a690b1-2e1d-4d7a-a4e7-e966bd1522bf"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8923), "Eid al-Adha", null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0f6fe09-2784-48c7-b22b-57e3005182c9"), new DateTime(2024, 12, 17, 10, 21, 52, 308, DateTimeKind.Local).AddTicks(8904), "Evacuation Day", null, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paid leave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
