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
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            return Redirect("Inicio");
        }

        public ActionResult Inicio()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            return View();
        }
        

        //Seccion de peliculas


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


        public ActionResult PeliculasEditar(int id)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }



            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();
            ViewBag.ListaDeCalificaciones = CalificacioneServicio.calificacioneServicio.ObtenerListaDeGeneros();

            return View(PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(id));
        }

        [HttpPost]
        public ActionResult PeliculasEditar(Pelicula pelicula)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            TempData["mensaje"] = "La pelicula ha sido editada exitosamente";


            PeliculaServicio.peliculaServicio.EditarPelicula(pelicula);

            ViewBag.ListaPeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();

            return Redirect("../Peliculas");
        }


        //Termina Seccion de Peliculas



        //Seccion de Sedes

        public ActionResult Sedes()
        {


            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }
            ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();

            return View();
        }

        public ActionResult SedesAgregar()
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            return View();
        }

        [HttpPost]
        public ActionResult SedesAgregar(Sede sede)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            SedeServicio.sedeServicio.AgregarSede(sede);

            TempData["mensaje"] = "La sede ha sido agregada exitosamente";

            return Redirect("Sedes");

        }

        public ActionResult SedesEditar(int id)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            return View(SedeServicio.sedeServicio.ObtenerSedePorId(id));
        }

        [HttpPost]
        public ActionResult SedesEditar(Sede sede)
        {
            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            SedeServicio.sedeServicio.EditarSede(sede);

            TempData["mensaje"] = "La sede ha sido editada exitosamente";

            return Redirect("../Sedes");

        }

        //Seccion Carteleras


        public ActionResult Carteleras()
        {


            if (Session["usuario"] == null)
            {
                return Redirect("../Home/Login");
            }

            

            //ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();

            //2014-04-04 00:00:00.000

            System.DateTime FechaActual = new DateTime(2016, 4, 4); //MEtenmos manualmente la fecha pero en realidad hay que recibirla

            return View(CarteleraServicio.carteleraServicio.ObtenerListaDeCartelerasPorFecha(FechaActual));
        }


    }
}
