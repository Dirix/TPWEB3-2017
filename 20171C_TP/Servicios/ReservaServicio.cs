using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class ReservaServicio : ControllerBase
    {

        public static ReservaServicio reservaServicio = new ReservaServicio();

        public void AgregarReserva(Reserva reserva)
        {
            RepositorioManager.Reservas.AgregarReserva(reserva);

        }

        public bool VerificarReserva(Reserva reserva)
        {

           

            return true;

        }

        public List<Reserva> ObtenerListaDeReservas()
        {

            return RepositorioManager.Reservas.ObtenerListaDeReservas();

        }

        public List<Reserva> FiltrarReservas(System.DateTime FechaInicio, System.DateTime FechaFinal, string NombrePelicula)
        {

            return RepositorioManager.Reservas.FiltrarReservas(FechaInicio, FechaFinal, NombrePelicula);

        }

        public int ObtenerNumeroDeReservas(System.DateTime FechaInicio, System.DateTime FechaFinal, string NombrePelicula)
        {
            return RepositorioManager.Reservas.ObtenerNumeroDeReservas(FechaInicio, FechaFinal, NombrePelicula);
        }

        public Reserva ObtenerReservaPorId(int id)
        {

            return RepositorioManager.Reservas.ObtenerReservaPorId(id);

        }


    }
}