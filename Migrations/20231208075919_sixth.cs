
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "371bc368-29c4-43de-b3c6-cb7259a25f5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "2fe115a6-164b-4bed-88bc-0f07a1cb3d97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1a2ed54-0a3e-4994-a6e2-54d691f74510", "AQAAAAEAACcQAAAAEFbuX+wiX10b6hwBWfY020RsHilDFLef5pcQ3W0+QQTzqsbjOwe+AcO2KLnFq0yZkw==", "3e93eb1f-32ac-4fac-977e-49a83f2b1879" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fa05379-930c-4523-8b53-fb567bfc4683", "AQAAAAEAACcQAAAAEHi38R5UVPFUBsJOt/E/0Q2ismiqb432yMskcSv1Av65AFWEYAh6DCuzoYFgYD3bJQ==", "a397c87b-4033-4ee0-b11d-d373f0f51bf2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "4a4b2f06-eba8-4296-b25b-6440c23614a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "82d18ffb-e35d-4d8e-bbee-a7f7b9dc6881");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45278b63-9fe6-4378-bb52-8d57a9b0d55f", "AQAAAAEAACcQAAAAEGp5ZH845CoFIXndDhut/+DykeZ6EvHCM2Z+Pc+pPn7XQ6nARfs9i2BKr0wevaLcgw==", "3f79c4cc-06f0-40dc-a050-32298537cb39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d3ae963-eca1-46cb-8fff-284e742f5dbd", "AQAAAAEAACcQAAAAEJ976dY2esY0M2SxdybNumsad4w2POZi+r90QWY0AQZxACnYyF9HThy3u722+QlwFg==", "62177a65-21e4-433f-b01f-f8d81d6bf5dc" });
        }
    }
}
