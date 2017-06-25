using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

            return RepositorioManager.Carteleras.ComprobarDisponibilidad(cartelera);

        }
 

        public Cartelera ObtenerCarteleraPorId(int id)
        {

            return RepositorioManager.Carteleras.ObtenerCarteleraPorId(id);

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



            return ListadoDeFechas;

        }

        public List<Versione> ObtenerVersionesPorIdPelicula(int idPelicula)
        {

            return RepositorioManager.Carteleras.ObtenerVersionesPorIdPelicula(idPelicula);

        }


        public List<Sede> ObtenerSedesPorIdVersionYPelicula(int idVersion, int idPelicula)
        {

            return RepositorioManager.Carteleras.ObtenerSedesPorIdVersionYPelicula(idVersion,idPelicula);

        }

    }
}