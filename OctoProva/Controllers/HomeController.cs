using Microsoft.AspNetCore.Mvc;
using OctoProva.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OctoProva.Controllers
{
    public class HomeController : Controller
    {   
        //Retornando View "Sobre"
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        //Retornando View "Contato"
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //Retornando View com possível Erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
