using OctoProva.Models;
using System.Linq;

namespace OctoProva.Data
{   //Serviço para povoar o Banco de dados
    public class SeedingService
    {
        private Contexto _contexto;

        public SeedingService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Seed()
        {
            if (_contexto.Clientes.Any())
            {
                return; // Banco de dados já possui registros
            }

            int n = 120;
            for(int i = 1; i < n; i++)
            {
                _contexto.Clientes.Add(new Cliente($"Roberto Bruno{i}", "108.309.312-22", "Celular", "11963722234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP"));
            }
           
            _contexto.SaveChanges();
        }
    }
}
