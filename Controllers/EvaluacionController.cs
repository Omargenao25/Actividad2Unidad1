using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        // GET: EvaluacionController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcularPromedio(decimal calificacion1, decimal calificacion2, decimal calificacion3, decimal calificacion4)
        {
            decimal promedio = CalcularPromedioCalificaciones(calificacion1, calificacion2, calificacion3, calificacion4);
            string estado = ObtenerEstadoEstudiante(promedio);
            ViewBag.Promedio = promedio;
            ViewBag.Estado = estado;
            return View();
        }

        private decimal CalcularPromedioCalificaciones(decimal c1, decimal c2, decimal c3, decimal c4)
        {
            return (c1 + c2 + c3 + c4) / 4;
        }

        private string ObtenerEstadoEstudiante(decimal promedio)
        {
            if (promedio >= 70)
                return "Aprobado";
            else if (promedio >= 60)
                return "En recuperación";
            else
                return "Reprobado";
        }
    }
}

