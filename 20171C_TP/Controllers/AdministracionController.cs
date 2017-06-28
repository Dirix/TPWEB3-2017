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
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }



            return View();
        }
        

        //Seccion de peliculas


        public ActionResult Peliculas()
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            ViewBag.ListaPeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();
            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();           

                       

            return View();
        }



        public ActionResult PeliculasAgregar()
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();
            ViewBag.ListaDeCalificaciones = CalificacioneServicio.calificacioneServicio.ObtenerListaDeGeneros();

            return View();
        }

        [HttpPost]
        public ActionResult PeliculasAgregar(Pelicula pelicula, HttpPostedFileBase file)
        {


            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }


            //Subimos archivo
            if (file == null)
                {
                    TempData["mensaje"] = "Ocurrio un error con la imagen subida";
                }


            string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file.FileName).ToLower();

            string directorio = "/Upload/Imagenes/" + archivo;

            archivo = archivo.Replace(" ", "");

            archivo = "~/Upload/Imagenes/" + archivo;

            file.SaveAs(Server.MapPath(archivo));

            pelicula.Imagen = directorio;

            //Fin de subida de archivo

            PeliculaServicio.peliculaServicio.AgregarPelicula(pelicula);

            ViewBag.ListaPeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();

            TempData["mensaje"] = "La pelicula ha sido agregada exitosamente";

            return Redirect("Peliculas");
        }


        public ActionResult PeliculasEditar(int id)
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }


            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();
            ViewBag.ListaDeCalificaciones = CalificacioneServicio.calificacioneServicio.ObtenerListaDeGeneros();

            return View(PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(id));
        }

        [HttpPost]
        public ActionResult PeliculasEditar(Pelicula pelicula, HttpPostedFileBase file)
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            TempData["mensaje"] = "La pelicula ha sido editada exitosamente";

            //Subimos archivo
            if (file == null)
            {
                TempData["mensaje"] = "Ocurrio un error con la imagen subida";
            }


            string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file.FileName).ToLower();

            string directorio = "../Upload/Imagenes/" + archivo;

            archivo = "~/Upload/Imagenes/" + archivo;

            file.SaveAs(Server.MapPath(archivo));

            pelicula.Imagen = directorio;

            //Fin de subida de archivo


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
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();

            return View();
        }

        public ActionResult SedesAgregar()
        {
            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            return View();
        }

        [HttpPost]
        public ActionResult SedesAgregar(Sede sede)
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            SedeServicio.sedeServicio.AgregarSede(sede);

            TempData["mensaje"] = "La sede ha sido agregada exitosamente";

            return Redirect("Sedes");

        }

        public ActionResult SedesEditar(int id)
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            return View(SedeServicio.sedeServicio.ObtenerSedePorId(id));
        }

        [HttpPost]
        public ActionResult SedesEditar(Sede sede)
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
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
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            

            //ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();

            //2014-04-04 00:00:00.000

            System.DateTime FechaActual = new DateTime(2016, 4, 4); //MEtenmos manualmente la fecha pero en realidad hay que recibirla

            ViewBag.ListaDeGeneros = GeneroServicio.generoServicio.ObtenerListaDeGeneros();
            ViewBag.ListaDePeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();

            //ViewBag.ListaDeFechas = CarteleraServicio.carteleraServicio.ObtenerListaDeFechas(13);
            


            return View(CarteleraServicio.carteleraServicio.ObtenerListaDeCarteleras());

        }

                            
        public ActionResult CartelerasAgregar()
        {

            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }



            ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();
            ViewBag.ListaDePeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();
            ViewBag.ListaDeVersiones = VersioneServicio.versioneServicio.ObtenerListaDeVersiones();

            return View(CarteleraServicio.carteleraServicio.ObtenerListaDeCarteleras());
        }


        [HttpPost]  
        public ActionResult CartelerasAgregar(Cartelera cartelera)
        {


            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }
            
            if (!CarteleraServicio.carteleraServicio.ComprobarDisponibilidad(cartelera))
            {
                TempData["mensaje"] = "No hay disponibilidad para el periodo, sede y sala seleccionada";
                return Redirect("~/Administracion/Carteleras");
            }

            //System.DateTime FechaInicial = new System.DateTime(2014, 4, 4); //MEtenmos manualmente la fecha pero en realidad hay que recibirla
            //System.DateTime FechaFinal = new System.DateTime(2014, 4, 4); //MEtenmos manualmente la fecha pero en realidad hay que recibirla

        
            
            //cartelera.FechaInicio = FechaInicial;
            //cartelera.FechaFin = FechaFinal;

            ViewBag.ListaDeSedes = SedeServicio.sedeServicio.ObtenerListaDeSedes();
            ViewBag.ListaDePeliculas = PeliculaServicio.peliculaServicio.ObtenerListaDePeliculas();
            ViewBag.ListaDeVersiones = VersioneServicio.versioneServicio.ObtenerListaDeVersiones();

            
            TempData["mensaje"] = "La cartelera ha sido creado exitosamente";

   

            CarteleraServicio.carteleraServicio.AgregarCartelera(cartelera);

            return Redirect("~/Administracion/Carteleras");
   
        }

        public ActionResult Reservas()
        {


            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }

            return View();

        }

        public ActionResult FiltrarReservas(System.DateTime id, System.DateTime id2, string id3)
        {


            if (Session["usuario"] == null)
            {
                TempData["UrlAdmin"] = Request.Url; //Guardamos la URL
                ViewBag.UrlAdmin = Request.Url; //Guardamos la URL
                return Redirect("../Home/Login"); //Redireccionamos al login
            }


            List<Reserva> Reservas = ReservaServicio.reservaServicio.FiltrarReservas(id, id2, id3);


            ViewBag.NumeroReservas = Reservas.Count();




            return View(Reservas);

        }

        //Cerrar Session
        public ActionResult cerrarSession()
        {


                Session.Abandon();
                return Redirect("../Home/Inicio");

        }



    }
}
