using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class CalificacioneServicio : ControllerBase
    {
        public static CalificacioneServicio calificacioneServicio = new CalificacioneServicio();

        public List<Calificacione> ObtenerListaDeGeneros()
        {
            return RepositorioManager.Calificaciones.ObtenerListaDeCalifaciones();

        }

        public string ObtenerCalificacionPorId(int MiId)
        {
            return RepositorioManager.Calificaciones.ObtenerCalificacionPorId(MiId);

        }
    }
}