using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        // GET: NumeroPerfectoController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EsPerfecto(int numero)
        {
            bool esPerfecto = EsNumeroPerfecto(numero);
            ViewBag.Mensaje = esPerfecto
                ? $"El número {numero} es perfecto."
                : $"El número {numero} no es perfecto.";
            return View();
        }

        private bool EsNumeroPerfecto(int numero)
        {
            if (numero <= 0)
                return false;

            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    sumaDivisores += i;
            }

            return sumaDivisores == numero;
        }
    }
}
