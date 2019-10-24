using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.Migrations
{
    public partial class CoupanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupan",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 12, nullable: false),
                    TimeStarts = table.Column<DateTime>(nullable: false),
                    TimeEnds = table.Column<DateTime>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    UsedCount = table.Column<int>(nullable: false),
                    TotalCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupan", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupan");
        }
    }
}
