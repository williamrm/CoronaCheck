using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vaccinator.Migrations.MvcType
{
    public partial class myMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Injection",
                columns: table => new
                {
                    idInjection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_rappel = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injection", x => x.idInjection);
                });

            migrationBuilder.CreateTable(
                name: "Vaccin",
                columns: table => new
                {
                    idVaccin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    num_lot = table.Column<int>(type: "int", nullable: false),
                    InjectionidInjection = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccin", x => x.idVaccin);
                    table.ForeignKey(
                        name: "FK_Vaccin_Injection_InjectionidInjection",
                        column: x => x.InjectionidInjection,
                        principalTable: "Injection",
                        principalColumn: "idInjection",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    idType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maladie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinidVaccin = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.idType);
                    table.ForeignKey(
                        name: "FK_Type_Vaccin_VaccinidVaccin",
                        column: x => x.VaccinidVaccin,
                        principalTable: "Vaccin",
                        principalColumn: "idVaccin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Type_VaccinidVaccin",
                table: "Type",
                column: "VaccinidVaccin");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccin_InjectionidInjection",
                table: "Vaccin",
                column: "InjectionidInjection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Vaccin");

            migrationBuilder.DropTable(
                name: "Injection");
        }
    }
}
