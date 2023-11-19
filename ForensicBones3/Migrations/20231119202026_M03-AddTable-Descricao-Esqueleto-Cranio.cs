using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones3.Migrations
{
    public partial class M03AddTableDescricaoEsqueletoCranio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    RelatorioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.RelatorioId);
                    table.ForeignKey(
                        name: "FK_Relatorios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventariosEsqueleto",
                columns: table => new
                {
                    InventarioEsqueletoId = table.Column<int>(type: "int", nullable: false),
                    RelatorioId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoEsqueleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosEsqueleto", x => x.InventarioEsqueletoId);
                    table.ForeignKey(
                        name: "FK_InventariosEsqueleto_Relatorios_InventarioEsqueletoId",
                        column: x => x.InventarioEsqueletoId,
                        principalTable: "Relatorios",
                        principalColumn: "RelatorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventariosCranio",
                columns: table => new
                {
                    InventarioCranioId = table.Column<int>(type: "int", nullable: false),
                    InventarioEsqueletoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoCranio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosCranio", x => x.InventarioCranioId);
                    table.ForeignKey(
                        name: "FK_InventariosCranio_InventariosEsqueleto_InventarioCranioId",
                        column: x => x.InventarioCranioId,
                        principalTable: "InventariosEsqueleto",
                        principalColumn: "InventarioEsqueletoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescricoesCranios",
                columns: table => new
                {
                    DescricaoCranioId = table.Column<int>(type: "int", nullable: false),
                    Frontal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocipital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Esfenoide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maxilar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NasalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hioide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartilagemTireoide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mandibula = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescricoesCranios", x => x.DescricaoCranioId);
                    table.ForeignKey(
                        name: "FK_DescricoesCranios_InventariosCranio_DescricaoCranioId",
                        column: x => x.DescricaoCranioId,
                        principalTable: "InventariosCranio",
                        principalColumn: "InventarioCranioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Relatorios_UsuarioId",
                table: "Relatorios",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescricoesCranios");

            migrationBuilder.DropTable(
                name: "InventariosCranio");

            migrationBuilder.DropTable(
                name: "InventariosEsqueleto");

            migrationBuilder.DropTable(
                name: "Relatorios");
        }
    }
}
