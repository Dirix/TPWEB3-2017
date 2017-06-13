using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class CarteleraRepositorio : RepositorioBase
    {
        public CarteleraRepositorio(TPEntities ctx): base(ctx)
        {
            
        }

        internal void AgregarCartelera(Cartelera cartelera)
        {

            MiContexto.Carteleras.Add(cartelera);
            MiContexto.SaveChanges();


        }

        internal void EditarCartelera(Cartelera cartelera)
        {

            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Domingo = cartelera.Domingo;            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Domingo = cartelera.Domingo;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).FechaCarga = cartelera.FechaCarga;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).FechaFin = cartelera.FechaFin;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).FechaInicio = cartelera.FechaInicio;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).HoraInicio = cartelera.HoraInicio;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).IdPelicula = cartelera.IdPelicula;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).IdSede = cartelera.IdSede;

            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).IdVersion = cartelera.IdVersion;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Jueves = cartelera.Jueves;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Lunes = cartelera.Lunes;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Martes = cartelera.Martes;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Miercoles = cartelera.Miercoles;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).NumeroSala = cartelera.NumeroSala;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Sabado = cartelera.Sabado;
            MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == cartelera.IdCartelera).Viernes = cartelera.Viernes;

            MiContexto.SaveChanges();


        }

        internal Cartelera ObtenerCarteleraPorId(int id)
        {

            return MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == id);

        }

        
        internal List<Cartelera> ObtenerListaDeCartelerasPorFecha(System.DateTime FechaActual)
        {

           //string dateString = "5/1/2008 8:30:52 AM"; este es el formato que trabaja
            //DateTime FechaActual = DateTime.Parse(FechaActualString, System.Globalization.CultureInfo.InvariantCulture);

            List<Cartelera> ListaDeCartelerasDeLaBusqueda = new List<Cartelera>();

            var lista = from miCartelera in MiContexto.Carteleras where (miCartelera.FechaInicio < FechaActual && miCartelera.FechaFin > FechaActual) select miCartelera;

            foreach (Cartelera miCartelera in lista)
            
            {
                ListaDeCartelerasDeLaBusqueda.Add(miCartelera);


            }


            return ListaDeCartelerasDeLaBusqueda;

        }

        

        internal List<Cartelera> ObtenerListaDeCarteleras()
        {

            return MiContexto.Carteleras.ToList();

        }

    }
}