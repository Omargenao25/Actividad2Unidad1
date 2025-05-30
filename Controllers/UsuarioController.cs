using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saludo(string nombre)
        {
            ViewBag.Mensaje = $"Hola, {nombre}, bienvenido a ASP.NET MVC.";
            return View();
        }

    }
}
