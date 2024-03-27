using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_OnlineKursApp_ProjesiCozumu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egitmenler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IseBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsiBirakmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitmenler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Seanslar",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EgitimGunleri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BitisSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanslar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teknolojiler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teknolojiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saat = table.Column<short>(type: "smallint", nullable: false),
                    ZorlukSeviyesi = table.Column<byte>(type: "tinyint", nullable: false),
                    TeknolojiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Urunler_Teknolojiler_TeknolojiId",
                        column: x => x.TeknolojiId,
                        principalTable: "Teknolojiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egitimler",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeansId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamSaat = table.Column<short>(type: "smallint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Egitimler_Seanslar_SeansId",
                        column: x => x.SeansId,
                        principalTable: "Seanslar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Egitimler_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitimEgitmen",
                columns: table => new
                {
                    EgitimlerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EgitmenlerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimEgitmen", x => new { x.EgitimlerID, x.EgitmenlerID });
                    table.ForeignKey(
                        name: "FK_EgitimEgitmen_Egitimler_EgitimlerID",
                        column: x => x.EgitimlerID,
                        principalTable: "Egitimler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitimEgitmen_Egitmenler_EgitmenlerID",
                        column: x => x.EgitmenlerID,
                        principalTable: "Egitmenler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitimOgrenci",
                columns: table => new
                {
                    EgitimlerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgrencilerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimOgrenci", x => new { x.EgitimlerID, x.OgrencilerID });
                    table.ForeignKey(
                        name: "FK_EgitimOgrenci_Egitimler_EgitimlerID",
                        column: x => x.EgitimlerID,
                        principalTable: "Egitimler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitimOgrenci_Ogrenciler_OgrencilerID",
                        column: x => x.OgrencilerID,
                        principalTable: "Ogrenciler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgitimEgitmen_EgitmenlerID",
                table: "EgitimEgitmen",
                column: "EgitmenlerID");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_SeansId",
                table: "Egitimler",
                column: "SeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitimler_UrunId",
                table: "Egitimler",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_EgitimOgrenci_OgrencilerID",
                table: "EgitimOgrenci",
                column: "OgrencilerID");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_TeknolojiId",
                table: "Urunler",
                column: "TeknolojiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgitimEgitmen");

            migrationBuilder.DropTable(
                name: "EgitimOgrenci");

            migrationBuilder.DropTable(
                name: "Egitmenler");

            migrationBuilder.DropTable(
                name: "Egitimler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Seanslar");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Teknolojiler");
        }
    }
}
