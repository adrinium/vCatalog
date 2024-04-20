using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vCatalogRazor.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareTabelNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valoare = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    DataAcordare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipNotaId = table.Column<int>(type: "int", nullable: false),
                    ElevId = table.Column<int>(type: "int", nullable: false),
                    ModulId = table.Column<int>(type: "int", nullable: false),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotShowLate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_Elevi_ElevId",
                        column: x => x.ElevId,
                        principalTable: "Elevi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Note_Module_ModulId",
                        column: x => x.ModulId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Note_Profesori_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Note_TipNote_TipNotaId",
                        column: x => x.TipNotaId,
                        principalTable: "TipNote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Note_ElevId",
                table: "Note",
                column: "ElevId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_ModulId",
                table: "Note",
                column: "ModulId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_ProfesorId",
                table: "Note",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_TipNotaId",
                table: "Note",
                column: "TipNotaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");
        }
    }
}
