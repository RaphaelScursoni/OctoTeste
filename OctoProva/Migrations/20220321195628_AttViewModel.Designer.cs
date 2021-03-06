// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OctoProva.Data;

namespace OctoProva.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220321195628_AttViewModel")]
    partial class AttViewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OctoProva.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("CNPJ")
                        .HasMaxLength(18);

                    b.Property<string>("CPF")
                        .HasMaxLength(14);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Complemento")
                        .HasMaxLength(50);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(18);

                    b.Property<string>("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Telefone1")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("Telefone2")
                        .HasMaxLength(13);

                    b.Property<string>("TipoCliente")
                        .HasMaxLength(30);

                    b.Property<string>("TipoEndereco")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("TipoTelefone1")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("TipoTelefone2")
                        .HasMaxLength(25);

                    b.Property<string>("UF")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
