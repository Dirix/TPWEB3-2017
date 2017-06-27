using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _20171C_TP.DTO;

namespace _20171C_TP.Servicios
{
    public class CarteleraServicio : ControllerBase
    {

        public static CarteleraServicio carteleraServicio = new CarteleraServicio();

        public void AgregarCartelera(Cartelera cartelera)
        {
            cartelera.FechaCarga = System.DateTime.Now;
            RepositorioManager.Carteleras.AgregarCartelera(cartelera);

        }

        public void EditarCartelera(Cartelera cartelera)
        {
            RepositorioManager.Carteleras.EditarCartelera(cartelera);

        }

 

        public List<Cartelera> ObtenerListaDeCarteleras()
        {

            return RepositorioManager.Carteleras.ObtenerListaDeCarteleras();

        }


        public List<Cartelera> ObtenerListaDeCartelerasPorFecha(System.DateTime FechaActual)
        {

            return RepositorioManager.Carteleras.ObtenerListaDeCartelerasPorFecha(FechaActual);

        }

        public List<Pelicula> ObtenerPeliculasPorFecha()
        {

            return RepositorioManager.Carteleras.ObtenerPeliculasPorFecha(System.DateTime.Now);

        }

        public List<Cartelera> ObtenerListaDeCartelerasVigentes()
        {

            return RepositorioManager.Carteleras.ObtenerListaDeCartelerasVigentes();

        }

        public bool ComprobarDisponibilidad(Cartelera cartelera)
        {

            Pelicula pelicula = PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(cartelera.IdPelicula);

            return RepositorioManager.Carteleras.ComprobarDisponibilidad(cartelera, pelicula.Duracion);

        }
 

        public Cartelera ObtenerCarteleraPorId(int id)
        {

            return RepositorioManager.Carteleras.ObtenerCarteleraPorId(id);

        }

        public int ObtenerDuracionPorIdCartelera(int id)
        {

            return RepositorioManager.Carteleras.ObtenerDuracionPorIdCartelera(id);

        }

        /*Anulado
        public List<System.DateTime> ObtenerListaDeFechas(int idCartelera)
        
        {

            Cartelera cartelera = CarteleraServicio.carteleraServicio.ObtenerCarteleraPorId(idCartelera);

            return RepositorioManager.Carteleras.ObtenerListaDeFechas(cartelera);

        }
        */
        public List<System.DateTime> ObtenerListaDeFechas(int idCartelera)
        {

            Cartelera cartelera = CarteleraServicio.carteleraServicio.ObtenerCarteleraPorId(idCartelera);

            List<System.DateTime> ListadoDeFechas = new List<System.DateTime>();

            //Obtenemos el listado de fechas segun FechaInicio y FechaFin
            ListadoDeFechas = RepositorioManager.Carteleras.ObtenerListaDeFechas(cartelera);


            //Ahora filtramos en el listado las fechas segun los dias de la semanas
            ListadoDeFechas = FechaServicio.fechaServicio.ObtenerSegunPeriodo(cartelera.Lunes, cartelera.Martes, cartelera.Miercoles, cartelera.Jueves,
                cartelera.Viernes, cartelera.Sabado, cartelera.Domingo, ListadoDeFechas);

            //Agregamos la hora a las fechas


            ListadoDeFechas = FechaServicio.fechaServicio.AgregarHora(ListadoDeFechas, cartelera.HoraInicio);

            return ListadoDeFechas;

        }

        public List<Versione> ObtenerVersionesPorIdPelicula(int idPelicula)
        {

            return RepositorioManager.Carteleras.ObtenerVersionesPorIdPelicula(idPelicula);

        }


        public List<SedeDTO> ObtenerSedesPorIdVersionYPelicula(int idVersion, int idPelicula)
        {
            List<SedeDTO> sedesDTO = new List<SedeDTO>();

            List<Sede> sedes = RepositorioManager.Carteleras.ObtenerSedesPorIdVersionYPelicula(idVersion,idPelicula);

            foreach (var i in sedes) {
                SedeDTO sede = new SedeDTO();
                sede.sedeId = i.IdSede;
                sede.nombreSede = i.Nombre;
                sede.direccion = i.Direccion;
                sedesDTO.Add(sede);

            }

            return sedesDTO;
        }

        public List<Cartelera> ObtenerCartelerasPorPelicula(int idPelicula, int idSede, int idVersion)
        {

            System.DateTime FechaActual = System.DateTime.Now;

            return RepositorioManager.Carteleras.ObtenerCartelerasPorPelicula(FechaActual, idPelicula, idSede, idVersion);

        }

        public List<System.DateTime> ObtenerLasFechasDePelicula(int idPelicula, int idSede, int idVersion)
        {

            List<System.DateTime> Fechas = new List<System.DateTime>();
            List<Cartelera> Carteleras = new List<Cartelera>();

            Carteleras = carteleraServicio.ObtenerCartelerasPorPelicula(idPelicula, idSede, idVersion);

            foreach (var i in Carteleras)
            {
                Fechas.AddRange(carteleraServicio.ObtenerListaDeFechas(i.IdCartelera));

            }


   


            //Fechas = FechaServicio.fechaServicio.FiltrarFechasRepetidas(Fechas);


            return Fechas.OrderBy(e=>e.Date).ToList();

        }

        public List<System.DateTime> ObtenerLasHorasDeLaPeliculas(int idPelicula, int idSede, int idVersion, System.DateTime f)
        {

            //Obtenemos primero todas las fechas con sus horarios
            List<System.DateTime> ListaDeFechas = carteleraServicio.ObtenerLasFechasDePelicula(idPelicula, idSede, idVersion);

            //Ahora filtramos las que correspondan a la fecha indicada



            return ListaDeFechas.Where(e => e.Day == f.Day && e.Month == f.Month && e.Year == f.Year).ToList();

        }

    }
}