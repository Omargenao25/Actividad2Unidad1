using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: CalculadoraController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculadora()
        {
            return View();
        }

        public ActionResult Calcular(double valor1, double valor2, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
            }
            ViewBag.Resultado = resultado;
            return View("Calculadora");
        }
    }
}
