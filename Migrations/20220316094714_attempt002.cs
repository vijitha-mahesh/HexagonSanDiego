using Microsoft.EntityFrameworkCore.Migrations;

namespace HexagonSanDiego.Migrations
{
    public partial class attempt002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomePageId",
                table: "images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelcometoText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelcometoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotogalleryText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmenitiesText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunityText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstergramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YellpLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_images_HomePageId",
                table: "images",
                column: "HomePageId");

            migrationBuilder.AddForeignKey(
                name: "FK_images_HomePages_HomePageId",
                table: "images",
                column: "HomePageId",
                principalTable: "HomePages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_images_HomePages_HomePageId",
                table: "images");

            migrationBuilder.DropTable(
                name: "HomePages");

            migrationBuilder.DropIndex(
                name: "IX_images_HomePageId",
                table: "images");

            migrationBuilder.DropColumn(
                name: "HomePageId",
                table: "images");
        }
    }
}
