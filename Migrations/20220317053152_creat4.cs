using Microsoft.EntityFrameworkCore.Migrations;

namespace HexagonSanDiego.Migrations
{
    public partial class creat4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "FloorPlans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "FloorPlans");
        }
    }
}
