using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HexagonSanDiego.Migrations
{
    public partial class creat3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FloorPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bath = table.Column<int>(type: "int", nullable: false),
                    SqFeet = table.Column<int>(type: "int", nullable: false),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FloorPlans");
        }
    }
}
