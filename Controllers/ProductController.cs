using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MeuPrimeiroProjeto.Models;

namespace MeuPrimeiroProjeto.Controllers
{
    public class ProductController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

    }
}
