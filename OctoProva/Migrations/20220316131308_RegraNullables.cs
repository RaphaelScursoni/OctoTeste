using Microsoft.EntityFrameworkCore.Migrations;

namespace OctoProva.Migrations
{
    public partial class RegraNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Clientes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Clientes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
