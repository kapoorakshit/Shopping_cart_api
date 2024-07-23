using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "9d4fa0a8-b69f-42fc-82c5-9c8dfdb711b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "538e2880-f22c-4317-b2a8-39dfce1f64c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8487018-4508-4751-a4b6-8832d048784c", "AQAAAAEAACcQAAAAECgUf/Db5aCl7zWPo+6ygGyeO9YaMUxLjddIJ4yoa/Jw+KsZo6u9LhkjJ4++LQVFOw==", "b1aef13f-7b61-48de-926b-2381aa7ed6d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2258db65-a2c1-4ba0-a3dd-eefd197d11f7", "AQAAAAEAACcQAAAAEIaxbdWXIR2gaxR39XwdkpaUExff2qjU+tDYraQo/Ug5LAjbUqFsjVzqTk/2vgZXlA==", "a8c5a8fd-8f8b-4a95-b749-b941115f160e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "199179e0-e1d6-483a-8f53-9580635e8e45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "340afe2c-f120-4d18-be87-25957a4d5e41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a43490db-c307-4837-aa66-cae74649abb7", "AQAAAAEAACcQAAAAEIeHMYU1fnXqW++2vS7/h2rC2BKlao/XSqDMMrrdHsMxyCZOaj7zbj9+mKjaTSfNpg==", "020f9563-1e65-447f-8466-8a83bbef820e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2131d7d7-04c6-452a-b6c9-cd979b28c8e5", "AQAAAAEAACcQAAAAEME4ndUwW2/aehMuGRb1pwOxV54CRd3R8x3l4J3mJpMwL5g4sLQQPrUxcGyRF+uvnQ==", "2e3ccdbd-3758-4261-bafb-2cf14d4a1dfb" });
        }
    }
}
