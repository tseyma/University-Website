using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace duzce_uni.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "duyurulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duyuruBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruTur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruTarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruIcerik1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruIcerik2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruIcerik3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duyurulars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "duyurulars");
        }
    }
}
