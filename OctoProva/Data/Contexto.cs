using Microsoft.EntityFrameworkCore;
using OctoProva.Models;

namespace OctoProva.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){

        }
    }
}
