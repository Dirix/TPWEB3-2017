using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class PeliculaServicio:ControllerBase
    {
        public static PeliculaServicio peliculaServicio = new PeliculaServicio();

        public void AgregarPelicula(Pelicula pelicula)
        {
            RepositorioManager.Peliculas.AgregarPelicula(pelicula);

        }

        public List<Pelicula> ObtenerListaDePeliculas()
        {

            return RepositorioManager.Peliculas.ObtenerListaDePeliculas();

        }


    }
}