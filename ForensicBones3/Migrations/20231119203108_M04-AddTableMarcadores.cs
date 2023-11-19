using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones3.Migrations
{
    public partial class M04AddTableMarcadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarcadoresCranios",
                columns: table => new
                {
                    MarcadoresCranioId = table.Column<int>(type: "int", nullable: false),
                    InventarioCranioId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frontal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Ocipital = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Esfenoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Maxilar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Vomer = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ParietalEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TemporalEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ConchaNasalEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EtmoideEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LacrimalEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    NasalEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ZigomaticoEsq = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ParietalDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TemporalDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ConchaNasalDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EtmoideDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    LacrimalDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ZigomaticoDir = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Hioide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CartilagemTireoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Mandibula = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcadoresCranios", x => x.MarcadoresCranioId);
                    table.ForeignKey(
                        name: "FK_MarcadoresCranios_InventariosCranio_MarcadoresCranioId",
                        column: x => x.MarcadoresCranioId,
                        principalTable: "InventariosCranio",
                        principalColumn: "InventarioCranioId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcadoresCranios");
        }
    }
}
