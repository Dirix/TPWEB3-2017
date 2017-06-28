using _20171C_TP.Controllers;
using _20171C_TP.DTO;
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

        public void AgregarReserva(PreReservaDTO preReservaDTO)
        {
            Reserva reserva = new Reserva();

            reserva.CantidadEntradas = preReservaDTO.Entradas;

            reserva.Email = preReservaDTO.Correo;
            reserva.FechaHoraInicio = preReservaDTO.FechaDate;
            reserva.IdPelicula = preReservaDTO.IdPelicula;
            reserva.IdSede = preReservaDTO.IdSede;
            reserva.IdTipoDocumento = preReservaDTO.idTipoDocumento;
            reserva.IdVersion = preReservaDTO.IdVersion;
            reserva.NumeroDocumento = preReservaDTO.NumeroDocumento.ToString();
            reserva.FechaCarga = System.DateTime.Now;
 

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

        public PreReservaDTO GenerarPreReserva(PreReservaDTO p)
        {


            p.FechaDate = FechaServicio.fechaServicio.ConvertirAFecha(p.FechaString);
            p.FechaDate = p.FechaDate.AddHours(p.HoraInt);

            p.pelicula = PeliculaServicio.peliculaServicio.ObtenerPeliculaPorId(p.IdPelicula);
            p.sede = SedeServicio.sedeServicio.ObtenerSedePorId(p.IdSede);
            p.version = VersioneServicio.versioneServicio.ObtenerVersionPorId(p.IdVersion);


            return p;

        }


    }
}