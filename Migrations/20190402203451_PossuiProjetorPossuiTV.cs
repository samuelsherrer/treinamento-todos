using Microsoft.EntityFrameworkCore.Migrations;

namespace DevWebBasico.Migrations
{
    public partial class PossuiProjetorPossuiTV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PossuiProjetor",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "PossuiTV",
                table: "Evento");
        }
    }
}
