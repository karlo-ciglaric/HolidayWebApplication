using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayWebApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Destination = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    NoOfDays = table.Column<int>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holidays");
        }
    }
}
