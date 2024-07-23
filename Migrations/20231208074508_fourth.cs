using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "6d12c6a1-4c11-4175-bf23-12c23f831d17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "bed71356-da47-4c2f-8335-92ecb133741d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad17df9-a14c-43b2-8840-bd16ef85e30a", "AQAAAAEAACcQAAAAEBM0Rj+8LySce6tMNzuEt2AMVB07clfNJSh5WPLGHezqW70NwCUauWxcPoEPiZa6rA==", "6bff384f-e62a-4408-bedb-07548e74c9fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1156c1ac-3f9e-4a34-930f-de5a150ad108", "AQAAAAEAACcQAAAAEMlWqAZWsIzo43WpvnfA9R1NKi4kHk4Zy1yf/ojtgLi97lmgTQQHHK72uZA+zsrARw==", "923a3445-f65d-4fb3-abf6-06bbe7b30978" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
