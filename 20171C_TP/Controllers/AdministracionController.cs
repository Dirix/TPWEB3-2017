using _20171C_TP.Models;
using _20171C_TP.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Controllers
{
    public class AdministracionController : Controller
    {
        //
        // GET: /Administracion/

            

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            return View();
        }

        public ActionResult Peliculas()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }
            ViewBag.ListaPeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();
            

            return View();
        }



        public ActionResult PeliculasAgregar()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();
            ViewBag.ListaDeCalificaciones = CalificacioneServicio.calificacioneServicio.ObtenerListaDeGeneros();

            return View();
        }

        [HttpPost]
        public ActionResult PeliculasAgregar(Pelicula pelicula)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            TempData["mensaje"] = "La pelicula ha sido agregada exitosamente";


            PeliculaServicio.peliculaServicio.AgregarPelicula(pelicula);

            ViewBag.ListaPeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();

            return Redirect("Peliculas");
        }

    }
}
