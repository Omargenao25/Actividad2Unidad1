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

        [HttpPost]
        public ActionResult Saludo(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                ViewBag.Mensaje = $"Hola, {nombre}, bienvenido a ASP.NET MVC.";
                return View();
            }
            else
            {
                // Si el nombre está vacío, redirige al usuario de vuelta a la página de inicio
                return RedirectToAction("Index");
            }
        }

    }
}
