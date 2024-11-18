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
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(561), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(563), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(782), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(783), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(785), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(863), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(863), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(866), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(867), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 11, 18, 11, 18, 0, 177, DateTimeKind.Local).AddTicks(869), "C-HR", "System" }
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
