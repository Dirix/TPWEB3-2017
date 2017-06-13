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

                        internal List<Reserva> ObtenerListaDeCartelerasPorFecha(System.DateTime FechaInicio, System.DateTime FechaFinal)
                        {

                            List<Reserva> ListaDeReservasDeLaBusqueda = new List<Reserva>();

                            var lista = from miReserva in MiContexto.Reservas where (miReserva.FechaCarga > FechaInicio && miReserva.FechaCarga < FechaFinal) select miReserva;

                            foreach (Reserva miReserva in lista)
                            {
                                ListaDeReservasDeLaBusqueda.Add(miReserva);


                            }


                            return ListaDeReservasDeLaBusqueda;

                        }
                        internal Reserva ObtenerReservaPorId(int id)
                        {

                            return MiContexto.Reservas.FirstOrDefault(e => e.IdReserva == id);

                        }

        
    }
}