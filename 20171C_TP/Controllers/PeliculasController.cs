using _20171C_TP.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20171C_TP.Models;
using _20171C_TP.DTO;

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



            List<System.DateTime> Fechas = CarteleraServicio.carteleraServicio.ObtenerLasFechasDePelicula(id,2,1); //idPelicula, idSede y idVersion

            ViewBag.TipoDocumentos = TiposDocumentosServicio.tiposDocumentosServicio.ObtenerListaDeTipos();

            ViewBag.Fechas = FechaServicio.fechaServicio.FiltrarFechasRepetidas(Fechas); //Para no repetir fechas 

            System.DateTime FechaDePreba = new System.DateTime(2017, 6, 26);

            ViewBag.Horarios = CarteleraServicio.carteleraServicio.ObtenerLasHorasDeLaPeliculas(id, 2, 1, FechaDePreba);

            return View(PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(id));
        }


        [HttpPost]
        public ActionResult ReservaDatos(int idPelicula, int idVersion, int idSede, String Fecha, int Hora)
        {

            return View();
        }  





        public JsonResult ObtenerSedesPorVersion(int id, int id2)
        {
            List<SedeDTO> sedes = CarteleraServicio.carteleraServicio.ObtenerSedesPorIdVersionYPelicula(id, id2);

            return Json(new { items = sedes }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerFechasPorSedes(int id, int id2, int id3)
        {
            List<System.DateTime> Fechas = CarteleraServicio.carteleraServicio.ObtenerLasFechasDePelicula(id2, id3, id); //idPelicula, idSede y idVersion



            Fechas = FechaServicio.fechaServicio.FiltrarFechasRepetidas(Fechas); //Para no repetir fechas 



            List<String> FechasEnString = FechaServicio.fechaServicio.ConvertirAString(Fechas);

            return Json(new { items = FechasEnString }, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult ObtenerHorarios(int id, int id2, int id3, string id4)
        {

            System.DateTime FechaRecibida = FechaServicio.fechaServicio.ConvertirAFecha(id4);

            List<System.DateTime> ListaDeHorarios = CarteleraServicio.carteleraServicio.ObtenerLasHorasDeLaPeliculas(id2, id3, id, FechaRecibida);

            List<HoraDTO> HorariosJSON = FechaServicio.fechaServicio.ConvertirHoraAString(ListaDeHorarios);


            return Json(new { items = HorariosJSON }, JsonRequestBehavior.AllowGet);
        }

    }
}
