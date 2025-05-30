using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// LoginController.cs
public class LoginController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Ingresar(string usuario, string contrasena)
    {
        if (EsUsuarioValido(usuario, contrasena))
        {
            return RedirectToAction("Bienvenido");
        }
        else
        {
            ViewBag.Mensaje = "Usuario incorrecto";
            return View();
        }
    }

    public ActionResult Bienvenido()
    {
        return View();
    }

    private bool EsUsuarioValido(string usuario, string contrasena)
    {
        return usuario == "admin" && contrasena == "123456";
    }
}

    

