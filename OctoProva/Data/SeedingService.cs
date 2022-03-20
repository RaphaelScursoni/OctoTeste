using OctoProva.Models;
using System.Linq;

namespace OctoProva.Data
{
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
                return; // DB has been seeded
            }

            Cliente c1 = new Cliente("Roberto Bruno 1", "108.309.312-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c2 = new Cliente("Roberto Bruno 2", "108.309.322-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c3 = new Cliente("Roberto Bruno 3", "108.309.332-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c4 = new Cliente("Roberto Bruno 4", "108.309.342-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c5 = new Cliente("Roberto Bruno 5", "108.309.352-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c6 = new Cliente("Roberto Bruno 6", "108.309.362-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c7 = new Cliente("Roberto Bruno 7", "108.309.372-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c8 = new Cliente("Roberto Bruno 8", "108.309.382-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c9 = new Cliente("Roberto Bruno 9", "108.309.392-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c10 = new Cliente("Roberto Bruno 10", "108.309.301-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c11 = new Cliente("Roberto Bruno 11", "108.309.312-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c12 = new Cliente("Roberto Bruno 12", "108.309.323-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c13 = new Cliente("Roberto Bruno 13", "108.309.334-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c14 = new Cliente("Roberto Bruno 14", "108.309.345-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c15 = new Cliente("Roberto Bruno 15", "108.309.356-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c16 = new Cliente("Roberto Bruno 16", "108.309.367-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c17 = new Cliente("Roberto Bruno 17", "108.309.378-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c18 = new Cliente("Roberto Bruno 18", "108.309.389-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c19 = new Cliente("Roberto Bruno 19", "108.309.390-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c20 = new Cliente("Roberto Bruno 20", "108.309.302-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c21 = new Cliente("Roberto Bruno 21", "108.309.112-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c22 = new Cliente("Roberto Bruno 22", "108.309.222-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c23 = new Cliente("Roberto Bruno 23", "108.309.332-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c24 = new Cliente("Roberto Bruno 24", "108.309.442-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c25 = new Cliente("Roberto Bruno 25", "108.309.552-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c26 = new Cliente("Roberto Bruno 26", "108.309.662-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c27 = new Cliente("Roberto Bruno 27", "108.309.772-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c28 = new Cliente("Roberto Bruno 28", "108.309.882-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c29 = new Cliente("Roberto Bruno 29", "108.309.992-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c30 = new Cliente("Roberto Bruno 30", "108.309.001-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c31 = new Cliente("Roberto Bruno 31", "108.301.312-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c32 = new Cliente("Roberto Bruno 32", "108.302.323-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c33 = new Cliente("Roberto Bruno 33", "108.303.334-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c34 = new Cliente("Roberto Bruno 34", "108.304.345-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c35 = new Cliente("Roberto Bruno 35", "108.305.356-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c36 = new Cliente("Roberto Bruno 36", "108.306.367-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c37 = new Cliente("Roberto Bruno 37", "108.307.378-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c38 = new Cliente("Roberto Bruno 38", "108.308.389-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c39 = new Cliente("Roberto Bruno 39", "108.309.390-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c40 = new Cliente("Roberto Bruno 40", "108.300.302-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c41 = new Cliente("Roberto Bruno 41", "108.319.112-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c42 = new Cliente("Roberto Bruno 42", "108.329.222-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c43 = new Cliente("Roberto Bruno 43", "108.339.332-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c44 = new Cliente("Roberto Bruno 44", "108.349.442-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c45 = new Cliente("Roberto Bruno 45", "108.359.552-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c46 = new Cliente("Roberto Bruno 46", "108.369.662-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c47 = new Cliente("Roberto Bruno 47", "108.379.772-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c48 = new Cliente("Roberto Bruno 48", "108.389.882-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c49 = new Cliente("Roberto Bruno 49", "108.399.992-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c50 = new Cliente("Roberto Bruno 50", "108.309.001-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c51 = new Cliente("Roberto Bruno 51", "108.101.312-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c52 = new Cliente("Roberto Bruno 52", "108.202.323-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c53 = new Cliente("Roberto Bruno 53", "108.303.334-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c54 = new Cliente("Roberto Bruno 54", "108.404.345-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c55 = new Cliente("Roberto Bruno 55", "108.505.356-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c56 = new Cliente("Roberto Bruno 56", "108.606.367-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c57 = new Cliente("Roberto Bruno 57", "108.707.378-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c58 = new Cliente("Roberto Bruno 58", "108.808.389-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c59 = new Cliente("Roberto Bruno 59", "108.909.390-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c60 = new Cliente("Roberto Bruno 60", "108.000.302-22", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");


            Cliente c61 = new Cliente("Roberto Bruno 61", "44.325.431/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c62 = new Cliente("Roberto Bruno 62", "44.325.432/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c63 = new Cliente("Roberto Bruno 63", "44.325.433/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c64 = new Cliente("Roberto Bruno 64", "44.325.434/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c65 = new Cliente("Roberto Bruno 65", "44.325.435/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c66 = new Cliente("Roberto Bruno 66", "44.325.436/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c67 = new Cliente("Roberto Bruno 67", "44.325.437/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c68 = new Cliente("Roberto Bruno 68", "44.325.438/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c69 = new Cliente("Roberto Bruno 69", "44.325.439/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c70 = new Cliente("Roberto Bruno 70", "44.325.430/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c71 = new Cliente("Roberto Bruno 71", "44.325.432/0001-51", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c72 = new Cliente("Roberto Bruno 72", "44.325.432/0001-52", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c73 = new Cliente("Roberto Bruno 73", "44.325.432/0001-53", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c74 = new Cliente("Roberto Bruno 74", "44.325.432/0001-54", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c75 = new Cliente("Roberto Bruno 75", "44.325.432/0001-55", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c76 = new Cliente("Roberto Bruno 76", "44.325.432/0001-56", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c77 = new Cliente("Roberto Bruno 77", "44.325.432/0001-57", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c78 = new Cliente("Roberto Bruno 78", "44.325.432/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c79 = new Cliente("Roberto Bruno 79", "44.325.432/0001-59", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c80 = new Cliente("Roberto Bruno 80", "44.325.432/0001-50", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c81 = new Cliente("Roberto Bruno 81", "41.325.431/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c82 = new Cliente("Roberto Bruno 82", "42.325.432/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c83 = new Cliente("Roberto Bruno 83", "43.325.433/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c84 = new Cliente("Roberto Bruno 84", "44.325.434/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c85 = new Cliente("Roberto Bruno 85", "45.325.435/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c86 = new Cliente("Roberto Bruno 86", "46.325.436/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c87 = new Cliente("Roberto Bruno 87", "47.325.437/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c88 = new Cliente("Roberto Bruno 88", "48.325.438/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c89 = new Cliente("Roberto Bruno 89", "49.325.439/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c90 = new Cliente("Roberto Bruno 90", "40.325.430/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c91 = new Cliente("Roberto Bruno 91", "44.325.431/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c92 = new Cliente("Roberto Bruno 92", "44.325.432/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c93 = new Cliente("Roberto Bruno 93", "44.325.433/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c94 = new Cliente("Roberto Bruno 94", "44.325.434/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c95 = new Cliente("Roberto Bruno 95", "44.325.435/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c96 = new Cliente("Roberto Bruno 96", "44.325.436/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c97 = new Cliente("Roberto Bruno 97", "44.325.437/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c98 = new Cliente("Roberto Bruno 98", "44.325.438/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c99 = new Cliente("Roberto Bruno 99", "44.325.439/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c100 = new Cliente("Roberto Bruno 100", "44.325.430/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c101 = new Cliente("Roberto Bruno 101", "44.325.412/0001-51", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c102 = new Cliente("Roberto Bruno 102", "44.325.422/0001-52", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c103 = new Cliente("Roberto Bruno 103", "44.325.432/0001-53", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c104 = new Cliente("Roberto Bruno 104", "44.325.442/0001-54", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c105 = new Cliente("Roberto Bruno 105", "44.325.452/0001-55", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c106 = new Cliente("Roberto Bruno 106", "44.325.462/0001-56", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c107 = new Cliente("Roberto Bruno 107", "44.325.472/0001-57", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c108 = new Cliente("Roberto Bruno 108", "44.325.482/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c109 = new Cliente("Roberto Bruno 109", "44.325.492/0001-59", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c110 = new Cliente("Roberto Bruno 110", "44.325.402/0001-50", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            Cliente c111 = new Cliente("Roberto Bruno 111", "44.325.112/0001-51", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c112 = new Cliente("Roberto Bruno 112", "44.325.222/0001-52", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c113 = new Cliente("Roberto Bruno 113", "44.325.332/0001-53", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c114 = new Cliente("Roberto Bruno 114", "44.325.442/0001-54", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c115 = new Cliente("Roberto Bruno 115", "44.325.552/0001-55", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c116 = new Cliente("Roberto Bruno 116", "44.325.662/0001-56", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c117 = new Cliente("Roberto Bruno 117", "44.325.772/0001-57", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c118 = new Cliente("Roberto Bruno 118", "44.325.882/0001-58", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c119 = new Cliente("Roberto Bruno 119", "44.325.992/0001-59", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");
            Cliente c120 = new Cliente("Roberto Bruno 120", "44.325.002/0001-50", "Celular", "(11)96372-2234", "", "", "roberto.bruno@gmail.com", "Residencial", "Rua Ermelindo Matarazzo", "13455-000", "334", "Casa", "São Miguel", "São Paulo", "SP");

            _contexto.Clientes.AddRange(
                c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,
                c11, c12, c13, c14, c15, c16, c17, c18, c19, c20,
                c21, c22, c23, c24, c25, c26, c27, c28, c29, c30,
                c31, c32, c33, c34, c35, c36, c37, c38, c39, c40,
                c41, c42, c43, c44, c45, c46, c47, c48, c49, c50,
                c51, c52, c53, c54, c55, c56, c57, c58, c59, c60,
                c61, c62, c63, c64, c65, c66, c67, c68, c69, c70,
                c71, c72, c73, c74, c75, c76, c77, c78, c79, c80,
                c81, c82, c83, c84, c85, c86, c87, c88, c89, c90,
                c91, c92, c93, c94, c95, c96, c97, c98, c99, c100,
                c101, c102, c103, c104, c105, c106, c107, c108, c109, c110,
                c111, c112, c113, c114, c115, c116, c117, c118, c119, c120
                );
            _contexto.SaveChanges();
        }
    }
}
