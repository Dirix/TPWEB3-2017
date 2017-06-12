using _20171C_TP.Models;
using _20171C_TP.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Controllers
{
    public class HomeController : ControllerBase
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return Redirect("Home/inicio");
        }

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if (UsuarioServicio.usuarioServicio.Autenticar(usuario) == true)
            {
                Session["usuario"] = usuario.NombreUsuario;
                return Redirect("../administracion/inicio");
            }
            else
            {
                TempData["error"] = "El usuario o clave ingresado es incorrecto";
                Session.Abandon();
                return View();
            }



        }

    }
}
