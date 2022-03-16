using Microsoft.EntityFrameworkCore.Migrations;

namespace OctoProva.Migrations
{
    public partial class AttDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoEndereco1",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoEndereco2",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoEndereco1",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoEndereco2",
                table: "Clientes");
        }
    }
}
