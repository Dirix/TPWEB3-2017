using _20171C_TP.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Controllers
{
    public class PeliculasController : Controller
    {
        //
        // GET: /Peliculas/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reserva(int id)
        {
            ViewBag.ListaDeVersiones = CarteleraServicio.carteleraServicio.ObtenerVersionesPorIdPelicula(id);

            return View(PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(id));
        }

        [ActionName("ObtenerSedesPorVersion")]
        public ActionResult ObtenerSedesPorVersion(int id, int id2)
        {
            var sedes = CarteleraServicio.carteleraServicio.ObtenerSedesPorIdVersionYPelicula(2, 43);
            return new JsonResult() { Data = sedes };
        }

    }
}
