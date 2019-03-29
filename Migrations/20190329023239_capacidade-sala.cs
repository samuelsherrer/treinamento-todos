using Microsoft.EntityFrameworkCore.Migrations;

namespace DevWebBasico.Migrations
{
    public partial class capacidadesala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacidade",
                table: "Sala",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidade",
                table: "Sala");
        }
    }
}
