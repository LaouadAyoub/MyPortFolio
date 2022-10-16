using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c5b995f9-e6ea-4ef4-a608-4c7603a8863f"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5b91d43-91c2-4256-a2cc-e494e06df477", 0, "81762e03-8f1a-498e-8d67-364b99c413e7", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "Admin@123456", null, false, "37c7b7a1-761d-4fbf-a108-5e0d68e48de0", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("2da19890-3a3a-4eea-a732-40e0f9cd461d"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b91d43-91c2-4256-a2cc-e494e06df477");

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2da19890-3a3a-4eea-a732-40e0f9cd461d"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("c5b995f9-e6ea-4ef4-a608-4c7603a8863f"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }
    }
}
