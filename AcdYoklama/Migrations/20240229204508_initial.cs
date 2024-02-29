using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcdYoklama.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ogrenci_adi = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ogrenci_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ogrenci_sinif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ogrenci_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.OgrenciId);
                });

            migrationBuilder.CreateTable(
                name: "Yoklama",
                columns: table => new
                {
                    YoklamaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ders_adi = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ders_saati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ders_ogretmeni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ders_konusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ders_ogrencileri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoklama", x => x.YoklamaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Yoklama");
        }
    }
}
