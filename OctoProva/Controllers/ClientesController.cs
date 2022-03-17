using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OctoProva.Models;
using System.Threading.Tasks;

namespace OctoProva.Controllers
{
    public class ClientesController : Controller
    {
        private readonly Contexto _contexto;

        public ClientesController(Contexto contexto)
        {   
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Clientes.ToListAsync());
        }


        [HttpGet]
        public IActionResult CriarCliente()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarCliente(Cliente cliente)
        {
            cliente.Validar();

            if (ModelState.IsValid)
            {
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
