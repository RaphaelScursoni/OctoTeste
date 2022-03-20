using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OctoProva.Models;
using OctoProva.Data;
using System.Threading.Tasks;
using X.PagedList;
using System.Linq;

namespace OctoProva.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Contexto _contexto;

        public ClientesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public ViewResult Index(int? pagina)
        {
            int tamanhoPagina = 10;
            int numeroPagina = pagina ?? 1;
            return View(_contexto.Clientes.OrderBy(p => p.Nome).ToPagedList(numeroPagina, tamanhoPagina));
        }


        [HttpGet]
        public IActionResult CriarCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarCliente(Cliente cliente)
        {
            if (cliente.CPF == null)
            {
                cliente.Documento = cliente.CNPJ;
                cliente = new Cliente(cliente.Nome, cliente.Documento, cliente.CNPJ, cliente.TipoCliente, cliente.TipoTelefone1, cliente.Telefone1, cliente.TipoTelefone2, cliente.Telefone2, cliente.Email, cliente.TipoEndereco, cliente.Endereco, cliente.CEP, cliente.Numero, cliente.Complemento, cliente.Bairro, cliente.Cidade, cliente.UF);
                _contexto.Add(cliente);
                if (cliente.Documento == null)
                {
                    return View(cliente);
                }
                _contexto.Add(cliente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else if(cliente.CNPJ == null)
            {
                cliente.Documento = cliente.CPF;
                cliente = new Cliente(cliente.Nome, cliente.Documento, cliente.CPF, cliente.TipoCliente, cliente.TipoTelefone1, cliente.Telefone1, cliente.TipoTelefone2, cliente.Telefone2, cliente.Email, cliente.TipoEndereco, cliente.Endereco, cliente.CEP, cliente.Numero, cliente.Complemento, cliente.Bairro, cliente.Cidade, cliente.UF);
                _contexto.Add(cliente);
                if (cliente.Documento == null)
                {
                    return View(cliente);
                }
                _contexto.Add(cliente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(cliente);

        }

        [HttpGet]
        public IActionResult AtualizarCliente(int? id)
        {
            if (id != null)
            {
                Cliente cliente = _contexto.Clientes.Find(id);
                return View(cliente);
            }

            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarCliente(int? id, Cliente cliente)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(cliente);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(cliente);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirCliente(int? id)
        {
            if (id != null)
            {
                Cliente cliente = _contexto.Clientes.Find(id);
                return View(cliente);
            }

            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirCliente(int? id, Cliente cliente)
        {
            if (id != null)
            {
                _contexto.Remove(cliente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }

    }
}
