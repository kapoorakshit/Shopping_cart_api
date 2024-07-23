using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_cart_api.Migrations
{
    public partial class nine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                column: "ConcurrencyStamp",
                value: "f7ef4579-21c0-4876-8ca0-6a1970d498cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                column: "ConcurrencyStamp",
                value: "3a77f423-9c72-4bbb-8b74-54733214412d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "549e71de-1107-4d76-9c63-4d686e2cdea0", "AQAAAAEAACcQAAAAEHQ0r2p2TYFm0VO3W3G5LXxCejLbr4FFJHc/Y0RNEmWyScgfzvX4lY3d5EdoOX3+gg==", "a887aa03-d5cd-4647-afb4-1cf9320393ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48f260dd-ac5d-4219-ad1e-3bbd1934fae3", "AQAAAAEAACcQAAAAEB8f5vU/Bv54YEk9TzkdQIts3e5SiOXug8ymUtULVqa+gQXYzQelxGQRMKqqLk9low==", "5bb19538-f44a-4388-8ebf-1ca630dee248" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
