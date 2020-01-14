using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoeSelling.Migrations
{
    public partial class Hasan_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoesSize",
                columns: table => new
                {
                    SizeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EuNumber = table.Column<int>(nullable: false),
                    UkNumber = table.Column<int>(nullable: false),
                    UsNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesSize", x => x.SizeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoesSize");
        }
    }
}
