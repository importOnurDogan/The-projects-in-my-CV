using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAPersonelTakipUygulamam.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Biyografi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departmani = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "Id", "DepartmanAdi" },
                values: new object[] { 2, "Maliye" });

            migrationBuilder.InsertData(
                table: "Personeller",
                columns: new[] { "Id", "Ad", "Biyografi", "Departmani", "DogumTarihi", "IseGirisTarihi", "Soyad", "Yas" },
                values: new object[] { 1, "Onur", "", "", new DateTime(1995, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogan", 28 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
