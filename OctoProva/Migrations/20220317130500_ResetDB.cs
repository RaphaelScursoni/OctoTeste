using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OctoProva.Migrations
{
    public partial class ResetDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    TipoCliente = table.Column<string>(maxLength: 30, nullable: false),
                    Documento = table.Column<string>(maxLength: 14, nullable: false),
                    TipoTelefone1 = table.Column<string>(maxLength: 12, nullable: false),
                    Telefone1 = table.Column<string>(maxLength: 12, nullable: false),
                    TipoTelefone2 = table.Column<string>(maxLength: 25, nullable: true),
                    Telefone2 = table.Column<string>(maxLength: 12, nullable: true),
                    TipoEndereco = table.Column<string>(maxLength: 25, nullable: false),
                    Endereco = table.Column<string>(maxLength: 100, nullable: false),
                    CEP = table.Column<string>(maxLength: 9, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: false),
                    Complemento = table.Column<string>(maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(maxLength: 50, nullable: false),
                    UF = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
