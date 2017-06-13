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

        public List<Reserva> ObtenerListaDeReservas()
        {

            return RepositorioManager.Reservas.ObtenerListaDeReservas();

        }

        public List<Reserva> ObtenerListaDeReservasPorFecha(System.DateTime FechaInicio, System.DateTime FechaFinal)
        {

            return RepositorioManager.Reservas.ObtenerListaDeCartelerasPorFecha(FechaInicio, FechaFinal);

        }

        public Reserva ObtenerReservaPorId(int id)
        {

            return RepositorioManager.Reservas.ObtenerReservaPorId(id);

        }


    }
}