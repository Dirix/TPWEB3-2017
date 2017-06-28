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


        internal bool ComprobarDisponibilidad(Cartelera cartelera, int duracionPelicula)
        {

            System.DateTime NuevaFechaInicio = cartelera.FechaInicio;
            System.DateTime NuevaFechaFin = cartelera.FechaFin;

            int intervaloSinPeliculas = 30;
            int test = duracionPelicula;
            int InicioHoraCarteleraRecibida = cartelera.HoraInicio * 60;
            int FinHoraCarteleraRecibida = cartelera.HoraInicio * 60 + duracionPelicula;

            List<Cartelera> CartelerasFiltradas = new List<Cartelera>();

            //Primero verificamos si choco la fecha indicada con otra cartelera
            if (MiContexto.Carteleras.Any(e => e.FechaInicio <= NuevaFechaInicio && e.FechaFin >= NuevaFechaInicio
             || e.FechaInicio <= NuevaFechaFin && e.FechaFin >= NuevaFechaFin))
            {
                CartelerasFiltradas = MiContexto.Carteleras.Where(e => e.FechaInicio <= NuevaFechaInicio && e.FechaFin >= NuevaFechaInicio
             || e.FechaInicio <= NuevaFechaFin && e.FechaFin >= NuevaFechaFin).ToList();

                //Verificamos si choco con una sede y sala
                if (CartelerasFiltradas.Any(e => e.IdSede == cartelera.IdSede && e.NumeroSala == cartelera.NumeroSala))
                {

                        CartelerasFiltradas = CartelerasFiltradas.Where(e => e.IdSede == cartelera.IdSede && e.NumeroSala == cartelera.NumeroSala).ToList();

                        //Verificamos si choco el horario de inicio
                        if (CartelerasFiltradas.Any(e => e.HoraInicio == cartelera.HoraInicio || e.HoraInicio == cartelera.HoraInicio + 1 || e.HoraInicio == cartelera.HoraInicio - 1))
                        {

       
                                //Verificamos si choca algun dia --Implementar
                                 
                                    //Si se cumplio todo es porque no hay disponibilidad
                                     return false;

        
                        }





                }
            
            }
            return true;

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

        internal int ObtenerDuracionPorIdCartelera(int id)
        {

            return MiContexto.Carteleras.FirstOrDefault(e => e.IdCartelera == id).Pelicula.Duracion;

        }

        
        internal List<Cartelera> ObtenerListaDeCartelerasPorFecha(System.DateTime FechaActual)
        {

           //string dateString = "5/1/2008 8:30:52 AM"; este es el formato que trabaja
            //DateTime FechaActual = DateTime.Parse(FechaActualString, System.Globalization.CultureInfo.InvariantCulture);

            //List<Cartelera> ListaDeCartelerasDeLaBusqueda = new List<Cartelera>();

            //var lista = from miCartelera in MiContexto.Carteleras where (miCartelera.FechaInicio < FechaActual && miCartelera.FechaFin > FechaActual) select miCartelera;

    //            foreach (Cartelera miCartelera in lista)
            
      //      {
        //        ListaDeCartelerasDeLaBusqueda.Add(miCartelera);


       //     }


            return MiContexto.Carteleras.Where(e => e.FechaInicio <= FechaActual && e.FechaFin >= FechaActual).ToList();

        }


        internal List<Pelicula> ObtenerPeliculasPorFecha(System.DateTime FechaActual)
        {

             List<Pelicula> lista = new List<Pelicula>();

            //Consulta SQL
            

            var peliculas = from peliculasCartelera in MiContexto.Carteleras
                      where peliculasCartelera.FechaFin >= FechaActual
                      select peliculasCartelera.Pelicula;




                        IEnumerable<Pelicula> ListaDePeliculasEnCarteleras = peliculas.Distinct();

                          foreach(Pelicula i in ListaDePeliculasEnCarteleras)
                          {
                              lista.Add(i);

    
                          }

            return lista;

        }

        internal List<Cartelera> ObtenerListaDeCartelerasVigentes()
        {

            System.DateTime FechaActual = System.DateTime.Now;
                
            return MiContexto.Carteleras.Where(e => e.FechaInicio <= FechaActual && e.FechaFin >= FechaActual).ToList();

        }
        

        internal List<Cartelera> ObtenerListaDeCarteleras()
        {

            //Tengo que actualizar estos registros para que pueda funcionar la vista
            MiContexto.Peliculas.ToList();
            MiContexto.Sedes.ToList();
            MiContexto.Versiones.ToList();

            return MiContexto.Carteleras.ToList();

        }



        internal List<System.DateTime> ObtenerListaDeFechas(Cartelera cartelera)
        {

        List<System.DateTime>  ListaDeFechas = new List<System.DateTime> ();




            //Si las funciones ya pasaron, no las mostramos y corremos la fecha de inicio a partir de hoy
        if (cartelera.FechaInicio < System.DateTime.Now)
        {
            cartelera.FechaInicio = System.DateTime.Now;
        }

        for (System.DateTime i = cartelera.FechaInicio; i < cartelera.FechaFin; i = i.AddDays(1))
            {
                ListaDeFechas.Add(i);
            }

        return ListaDeFechas;

        }

 
        internal List<Versione> ObtenerVersionesPorIdPelicula(int idPelicula)
        {

            List<Versione> ListaDeVersionesDisponibles = new List<Versione>();



            var versiones = from versionesCartelera in MiContexto.Carteleras
                            where versionesCartelera.IdPelicula == idPelicula
                            select versionesCartelera.Versione;




            IEnumerable<Versione> ListaDeVersiones = versiones.Distinct();

            foreach (Versione i in ListaDeVersiones)
            {
                ListaDeVersionesDisponibles.Add(i);


            }


            return ListaDeVersionesDisponibles.ToList();

        }


        internal List<Sede> ObtenerSedesPorIdVersionYPelicula(int idVersion, int idPelicula)
        {

            List<Sede> ListaDeSedesDisponibles = new List<Sede>();



            var sedes = from sedesCartelera in MiContexto.Carteleras
                        where sedesCartelera.IdPelicula == idPelicula && sedesCartelera.IdVersion==idVersion
                        select sedesCartelera.Sede;




            IEnumerable<Sede> ListaDeSedes = sedes.Distinct();

            foreach (Sede i in ListaDeSedes)
            {
                ListaDeSedesDisponibles.Add(i);


            }


            return ListaDeSedesDisponibles.ToList();

        }

        internal List<Cartelera> ObtenerCartelerasPorPelicula(System.DateTime FechaActual, int idPelicula, int idSede, int idVersion)
        {


            return MiContexto.Carteleras.Where(e => e.FechaFin >= FechaActual && e.IdPelicula == idPelicula && e.IdSede==idSede && e.IdVersion ==idVersion).ToList();

        }

    }
}