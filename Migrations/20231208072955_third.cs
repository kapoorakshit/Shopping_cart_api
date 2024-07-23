using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "e7bbd297-f90a-4981-bb89-acd93db2898d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "ab240abd-8c8c-4c2c-8712-8559f219bbfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8713d0fe-1033-415a-b99c-5ab853f18e23", "AQAAAAEAACcQAAAAEOXTEFiFFioWC3haXH/Qs9B62nM33usz3GTu0KS9vSwwrBZhWzNK8NSmDldiE9g1xg==", "9ef463d1-f384-4b23-aee3-1793ea8841df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4212962-398b-469f-bb86-1e740322a13b", "AQAAAAEAACcQAAAAEHpNex2cfj1e41iCivpcF6uONFGa/jdn5hWxDbSXWaVkJuejgqbBmL3BbC213ldkbg==", "23ade5b8-ada5-496e-8210-b1ba982eeb98" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
