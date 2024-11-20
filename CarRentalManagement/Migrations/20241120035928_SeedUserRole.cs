using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "28adf92a-61b9-4a4b-b64d-018f96be92d9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAEK85qTLx4LBKZmVU/pDf81VrEqFo+agVNoCS2f4OCOLKcE6SI61svA15NMsgW1Mg==", null, false, "fa5a6a11-549b-4339-9ab1-e3abcb923e60", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5823), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5829), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 11, 20, 11, 59, 27, 304, DateTimeKind.Local).AddTicks(5831) });

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
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(8914), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(8927), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9091), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9162), new DateTime(2024, 11, 20, 11, 26, 31, 40, DateTimeKind.Local).AddTicks(9163) });
        }
    }
}
