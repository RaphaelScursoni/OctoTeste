using Microsoft.EntityFrameworkCore;
using OctoProva.Models;

namespace OctoProva.Data
{  //Instanciando novo Banco de dados para os Clientes
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){

        }
    }
}
