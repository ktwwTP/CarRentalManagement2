using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4996dad3-5466-4142-b3e0-10cf527acd86", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHiVGbubZbJaHI8HZZ+Q2s4EVJAuEF2RtctCgZ6vng5v4FVrETgNQzcwr8D0qYezIw==", null, false, "fa874fe3-00c6-48b3-9a17-efa27cf584f1", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(6813), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(6827), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7074), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7076), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7186), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7188), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7192), new DateTime(2025, 12, 4, 22, 2, 38, 316, DateTimeKind.Local).AddTicks(7193) });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(71), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(86), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(615), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(618), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(709), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(712), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(714), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(716), new DateTime(2025, 12, 4, 21, 41, 57, 894, DateTimeKind.Local).AddTicks(717) });
        }
    }
}
