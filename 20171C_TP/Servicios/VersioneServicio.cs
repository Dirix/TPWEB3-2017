using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class VersioneServicio:ControllerBase
    {

        public static VersioneServicio versioneServicio = new VersioneServicio();

        public List<Versione> ObtenerListaDeVersiones()
        {

            return RepositorioManager.Versiones.ObtenerListaDeVersiones();

        }

        public Versione ObtenerVersionPorId(int idVersione)
        {

            return RepositorioManager.Versiones.ObtenerVersionPorId(idVersione);

        }

    }
}