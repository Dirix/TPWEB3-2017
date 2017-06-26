using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class ReservaRepositorio : RepositorioBase
    {
        public ReservaRepositorio(TPEntities ctx): base(ctx)
        {       
        }
                        internal void AgregarReserva(Reserva reserva)
                        {

                            MiContexto.Reservas.Add(reserva);
                            MiContexto.SaveChanges();


                        }




                        internal List<Reserva> ObtenerListaDeReservas()
                        {

                            return MiContexto.Reservas.ToList();

                        }

                        internal List<Reserva> FiltrarReservas(System.DateTime FechaInicio, System.DateTime FechaFinal, string NombrePelicula)
                        {

                            List<Reserva> ResultadoDeReservas = new List<Reserva>();

                            int CantidadElementos=2;

                            ResultadoDeReservas = MiContexto.Reservas.Where(e => FechaInicio <= e.FechaHoraInicio && FechaFinal >= e.FechaHoraInicio && e.Pelicula.Nombre.Contains(NombrePelicula)).ToList();


                            return ResultadoDeReservas;

                        }

                        internal int ObtenerNumeroDeReservas(System.DateTime FechaInicio, System.DateTime FechaFinal, string NombrePelicula)
                        {

                            return MiContexto.Reservas.Count(e => FechaInicio <= e.FechaHoraInicio && FechaFinal >= e.FechaHoraInicio && e.Pelicula.Nombre.Contains(NombrePelicula));

                        }
                        internal Reserva ObtenerReservaPorId(int id)
                        {

                            return MiContexto.Reservas.FirstOrDefault(e => e.IdReserva == id);

                        }

        
    }
}