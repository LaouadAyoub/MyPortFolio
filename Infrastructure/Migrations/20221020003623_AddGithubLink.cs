using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGithubLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c4d03203-e0ba-4053-8cb4-c2efa64ecb67"));

            migrationBuilder.AddColumn<string>(
                name: "GithubLink",
                table: "PortFolioItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("139056ec-00c2-4019-891a-c8a168557c08"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("139056ec-00c2-4019-891a-c8a168557c08"));

            migrationBuilder.DropColumn(
                name: "GithubLink",
                table: "PortFolioItems");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("c4d03203-e0ba-4053-8cb4-c2efa64ecb67"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }
    }
}
