using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7431), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7443), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7446), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7446), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7620), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7621), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7623), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7698), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7700), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7700), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7702), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7703), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7704), new DateTime(2025, 12, 4, 21, 13, 5, 447, DateTimeKind.Local).AddTicks(7705), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
