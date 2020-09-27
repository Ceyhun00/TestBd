using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestBd.Migrations
{
    public partial class ao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreateOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
