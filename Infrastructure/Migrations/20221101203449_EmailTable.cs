using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EmailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c4d03203-e0ba-4053-8cb4-c2efa64ecb67"));
    

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emaill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("95179f24-16cb-45b5-a157-29cb9ab8be41"), "pdp.jfif", "Ayoub LAOUAD", "Backend developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("95179f24-16cb-45b5-a157-29cb9ab8be41"));

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
