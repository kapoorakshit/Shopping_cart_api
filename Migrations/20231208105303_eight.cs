using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "c10cad19-c22c-408a-a3f4-24ce09215dd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "d5bf1c25-d55c-4bec-8f9e-999393e55bf9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436fc59d-cacf-4467-a51e-ebf281f173b1", "AQAAAAEAACcQAAAAEGn4GPOsIYZoE5dC4FxWL9hOlRAXaqW1SjbKIkc5Udzw4B5T9cvavv5d9PULZP3WNQ==", "6d1e9e93-def5-4610-8cd4-2ae902d35fad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "accf8d79-baa7-47a3-96c2-8ec4077d8a4f", "AQAAAAEAACcQAAAAEJ/5j13yL4BtqWNd3IpeEVemCNv65pJec33uaXJw3Kd7fZBauc9rO7Qyy4QZ2ifd1A==", "3f9938f9-10de-4b17-97e0-1de16cfe9676" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
