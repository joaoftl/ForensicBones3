using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones3.Migrations
{
    public partial class M05UpdateTableMarcadores_InvCranio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartilagemTireoide",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "ConchaNasalDir",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "ConchaNasalEsq",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Esfenoide",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "EtmoideDir",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "EtmoideEsq",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Frontal",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Hioide",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "LacrimalDir",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "LacrimalEsq",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Mandibula",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Maxilar",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "NasalEsq",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "Ocipital",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "ParietalDir",
                table: "MarcadoresCranios");

            migrationBuilder.DropColumn(
                name: "ParietalEsq",
                table: "MarcadoresCranios");

            migrationBuilder.RenameColumn(
                name: "ZigomaticoEsq",
                table: "MarcadoresCranios",
                newName: "SupraOrbital");

            migrationBuilder.RenameColumn(
                name: "ZigomaticoDir",
                table: "MarcadoresCranios",
                newName: "ProcessoMastoide");

            migrationBuilder.RenameColumn(
                name: "Vomer",
                table: "MarcadoresCranios",
                newName: "EminenciaMentoniana");

            migrationBuilder.RenameColumn(
                name: "TemporalEsq",
                table: "MarcadoresCranios",
                newName: "CristaNucal");

            migrationBuilder.RenameColumn(
                name: "TemporalDir",
                table: "MarcadoresCranios",
                newName: "AreaGlabela");

            migrationBuilder.AddColumn<int>(
                name: "CartilagemTireoide",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConchaNasalDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConchaNasalEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Esfenoide",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EtmoideDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EtmoideEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Frontal",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hioide",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LacrimalDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LacrimalEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mandibula",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Maxilar",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NasalEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ocipital",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParietalDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParietalEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemporalDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemporalEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vomer",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZigomaticoDir",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZigomaticoEsq",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartilagemTireoide",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ConchaNasalDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ConchaNasalEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Esfenoide",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "EtmoideDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "EtmoideEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Frontal",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Hioide",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "LacrimalDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "LacrimalEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Mandibula",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Maxilar",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "NasalEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Ocipital",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ParietalDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ParietalEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "TemporalDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "TemporalEsq",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "Vomer",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ZigomaticoDir",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "ZigomaticoEsq",
                table: "InventariosCranio");

            migrationBuilder.RenameColumn(
                name: "SupraOrbital",
                table: "MarcadoresCranios",
                newName: "ZigomaticoEsq");

            migrationBuilder.RenameColumn(
                name: "ProcessoMastoide",
                table: "MarcadoresCranios",
                newName: "ZigomaticoDir");

            migrationBuilder.RenameColumn(
                name: "EminenciaMentoniana",
                table: "MarcadoresCranios",
                newName: "Vomer");

            migrationBuilder.RenameColumn(
                name: "CristaNucal",
                table: "MarcadoresCranios",
                newName: "TemporalEsq");

            migrationBuilder.RenameColumn(
                name: "AreaGlabela",
                table: "MarcadoresCranios",
                newName: "TemporalDir");

            migrationBuilder.AddColumn<string>(
                name: "CartilagemTireoide",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConchaNasalDir",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConchaNasalEsq",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Esfenoide",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EtmoideDir",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EtmoideEsq",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Frontal",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hioide",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LacrimalDir",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LacrimalEsq",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mandibula",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maxilar",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NasalEsq",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ocipital",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParietalDir",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParietalEsq",
                table: "MarcadoresCranios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }
    }
}
