using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoeSelling.Migrations
{
    public partial class OGUZHAN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shoe",
                columns: table => new
                {
                    ShoeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoID = table.Column<string>(nullable: false),
                    SizeID = table.Column<string>(nullable: false),
                    ColorID = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    OrderID = table.Column<string>(nullable: false),
                    SeasonID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoe", x => x.ShoeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoe");
        }
    }
}
