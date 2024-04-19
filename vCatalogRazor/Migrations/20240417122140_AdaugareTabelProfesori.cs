using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vCatalogRazor.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareTabelProfesori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Clase",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profesori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Functie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAngajare = table.Column<DateOnly>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesori", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clase_ProfesorId",
                table: "Clase",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clase_Profesori_ProfesorId",
                table: "Clase",
                column: "ProfesorId",
                principalTable: "Profesori",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clase_Profesori_ProfesorId",
                table: "Clase");

            migrationBuilder.DropTable(
                name: "Profesori");

            migrationBuilder.DropIndex(
                name: "IX_Clase_ProfesorId",
                table: "Clase");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Clase");
        }
    }
}
