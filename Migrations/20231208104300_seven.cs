using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "5e4e1479-8d81-4ef7-9464-a267ac4e42c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "5d4c5f37-6ffa-4347-be19-d50136bdd18b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e52f72ed-b549-4fcf-a533-9a708c9a78a4", "AQAAAAEAACcQAAAAEBIwnkxcsJX3qwWOyg8MeUVbDWfw54/ivYNg456cm/SgGx2z+NH7hcELgqmev2vFhg==", "24876ec0-39e4-4ad8-8b2c-4f0fb53e882c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c616fef-9210-4b7c-bd85-636f4299e085", "AQAAAAEAACcQAAAAEL4XBQwQQYqK87OWZgJ7kH/+0AP8ST9DyyvotsBryMBShFiuCqJ1BofRPutZfKkiyg==", "7d00dd92-45e9-4429-b5ce-b5812f938ac9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
