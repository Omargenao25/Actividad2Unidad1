using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        // GET: NumeroController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EsPrimo(int numero)
        {
            bool esPrimo = EsNumeroPrimo(numero);
            ViewBag.Mensaje = esPrimo
                ? $"El número {numero} es primo."
                : $"El número {numero} no es primo.";
            return View();
        }

        private bool EsNumeroPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
