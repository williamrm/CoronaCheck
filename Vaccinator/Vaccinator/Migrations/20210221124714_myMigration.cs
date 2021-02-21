using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vaccinator.Migrations
{
    public partial class myMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    idPersonne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexe = table.Column<bool>(type: "bit", nullable: false),
                    date_naissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isResident = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.idPersonne);
                });

            migrationBuilder.CreateTable(
                name: "Injection",
                columns: table => new
                {
                    idInjection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_rappel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonneidPersonne = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injection", x => x.idInjection);
                    table.ForeignKey(
                        name: "FK_Injection_Personne_PersonneidPersonne",
                        column: x => x.PersonneidPersonne,
                        principalTable: "Personne",
                        principalColumn: "idPersonne",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Injection_PersonneidPersonne",
                table: "Injection",
                column: "PersonneidPersonne");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Injection");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
