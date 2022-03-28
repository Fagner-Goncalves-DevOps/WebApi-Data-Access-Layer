using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DashTelecom.Api.Migrations
{
    public partial class DbModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabTelecomConsolidado",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Dia = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Fila = table.Column<int>(type: "int", nullable: true),
                    Terminator = table.Column<string>(type: "varchar(100)", nullable: true),
                    StatusInicial = table.Column<string>(type: "varchar(255)", nullable: true),
                    StatusFinal = table.Column<string>(type: "varchar(100)", nullable: true),
                    Classe = table.Column<string>(type: "varchar(255)", nullable: true),
                    Bilhetado = table.Column<int>(type: "int", nullable: true),
                    Disparos = table.Column<int>(type: "int", nullable: false),
                    Custo = table.Column<decimal>(type: "decimal ", nullable: false),
                    Maior30 = table.Column<int>(nullable: true),
                    Menor30 = table.Column<int>(nullable: true),
                    DisparosTarifados = table.Column<int>(type: "int", nullable: true),
                    Servidor = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabTelecomConsolidado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabTelecomOperadoras",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Rota = table.Column<string>(type: "varchar(255)", nullable: true),
                    Operadora = table.Column<string>(type: "varchar(255)", nullable: true),
                    Tipo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Pag_sub = table.Column<string>(type: "varchar(255)", nullable: true),
                    Tecnologia = table.Column<string>(type: "varchar(100)", nullable: true),
                    Operadora_ftr = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabTelecomOperadoras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabTelecomConsolidado");

            migrationBuilder.DropTable(
                name: "TabTelecomOperadoras");
        }
    }
}
