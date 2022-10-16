using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f21759f2-39e9-4453-a16e-9f8fa1e74b08"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("0c51e583-0438-471e-89bc-e80cf8c0e8bd"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0c51e583-0438-471e-89bc-e80cf8c0e8bd"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("f21759f2-39e9-4453-a16e-9f8fa1e74b08"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }
    }
}
