using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevWebBasico.Migrations
{
    public partial class PossuiProjetorPossuiTV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PossuiProjetor",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "PossuiTV",
                table: "Evento");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Sala",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PossuiProjetor",
                table: "Sala",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PossuiTV",
                table: "Sala",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Sala");

            migrationBuilder.DropColumn(
                name: "PossuiProjetor",
                table: "Sala");

            migrationBuilder.DropColumn(
                name: "PossuiTV",
                table: "Sala");

            migrationBuilder.AddColumn<bool>(
                name: "PossuiProjetor",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PossuiTV",
                table: "Evento",
                nullable: false,
                defaultValue: false);
        }
    }
}
