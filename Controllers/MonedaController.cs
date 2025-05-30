using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        // GET: MonedaController
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult Convertir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Convertir(decimal montoDOP, string divisa)
        {
            decimal resultado = 0;
            string mensaje = "";

            // Tasas ficticias
            if (divisa == "USD")
            {
                resultado = montoDOP * 0.017m;
                mensaje = $"{montoDOP} DOP = {resultado:F2} USD";
            }
            else if (divisa == "EUR")
            {
                resultado = montoDOP * 0.015m;
                mensaje = $"{montoDOP} DOP = {resultado:F2} EUR";
            }

            ViewBag.Mensaje = mensaje;
            return View();
        }
    }
}
