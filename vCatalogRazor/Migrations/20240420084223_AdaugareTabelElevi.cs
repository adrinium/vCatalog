using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vCatalogRazor.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareTabelElevi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elevi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrenumeTata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrenumeMama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerieNumarCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNastere = table.Column<DateOnly>(type: "date", nullable: true),
                    LocNastere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etnie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StareCivila = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonMobil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonFix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotografie = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AdresaStrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaNumar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaBloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaScara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaEtaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaApartament = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaLocalitate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresaJudet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumarMatricol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodBiblioteca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PromotieId = table.Column<int>(type: "int", nullable: false),
                    ClasaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elevi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elevi_Clase_ClasaId",
                        column: x => x.ClasaId,
                        principalTable: "Clase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elevi_Promotii_PromotieId",
                        column: x => x.PromotieId,
                        principalTable: "Promotii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elevi_ClasaId",
                table: "Elevi",
                column: "ClasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elevi_PromotieId",
                table: "Elevi",
                column: "PromotieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elevi");
        }
    }
}
