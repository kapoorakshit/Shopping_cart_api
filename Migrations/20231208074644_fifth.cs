using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
