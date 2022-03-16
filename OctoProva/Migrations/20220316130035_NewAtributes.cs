using Microsoft.EntityFrameworkCore.Migrations;

namespace OctoProva.Migrations
{
    public partial class NewAtributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoCliente",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoCliente",
                table: "Clientes");
        }
    }
}
