using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class GeneroServicio : ControllerBase
    {
        public static GeneroServicio generoServicio = new GeneroServicio();

        public List<Genero> ObtenerListaDeGeneros()
        {
           return RepositorioManager.Generos.ObtenerListaDeGeneros();

        }


        public string ObtenerGeneroPorId(int MiId)
        {
            return RepositorioManager.Generos.ObtenerGeneroPorId(MiId);

        }
    }
}