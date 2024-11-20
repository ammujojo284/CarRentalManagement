using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8108), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8112), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8537), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8539), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8540), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8726), "I4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8730), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8732), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 11, 20, 12, 43, 10, 526, DateTimeKind.Local).AddTicks(8735), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
