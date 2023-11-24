using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "601f8eda-80e3-4138-b451-2b1393a364eb", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOcdOTm5Knup4s+bpT+XxCEq4Z/VtnIKXaFgNPgjA3j/ekms21U+P7NPCHPa5GctXg==", null, false, "89209917-075a-463b-90de-40bb809074ed", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(2669), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(2674), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3106), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3109), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3353), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3355), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3356), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3357), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 11, 24, 21, 43, 31, 313, DateTimeKind.Local).AddTicks(3361), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
