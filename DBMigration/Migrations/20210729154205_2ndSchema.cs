using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBMigration.Migrations
{
    public partial class _2ndSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: true),
                    Name = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test");

           
        }
    }
}
