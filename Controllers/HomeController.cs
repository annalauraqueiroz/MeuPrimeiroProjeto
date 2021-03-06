using MeuPrimeiroProjeto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Responder(Resposta resposta)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AdicionarResposta(resposta);
                return View("Obrigada");
            }
            else
            {
                return View(resposta);
            }
            
        }

        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }

        [HttpGet]
        [Route("ProductController/Products/Index.cshtml")]
        public IActionResult Products()
        {
            return View("~/Views/Products/Index.cshtml");
        }
    }
}
