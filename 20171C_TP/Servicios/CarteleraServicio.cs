using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class CarteleraServicio : ControllerBase
    {

        public static CarteleraServicio carteleraServicio = new CarteleraServicio();

        public void AgregarCartelera(Cartelera cartelera)
        {
            RepositorioManager.Carteleras.AgregarCartelera(cartelera);

        }

        public void EditarCartelera(Cartelera cartelera)
        {
            RepositorioManager.Carteleras.EditarCartelera(cartelera);

        }

 

        public List<Cartelera> ObtenerListaDeCarteleras()
        {

            return RepositorioManager.Carteleras.ObtenerListaDeCarteleras();

        }


        public List<Cartelera> ObtenerListaDeCartelerasPorFecha(System.DateTime FechaActual)
        {

            return RepositorioManager.Carteleras.ObtenerListaDeCartelerasPorFecha(FechaActual);

        }
         

        public Cartelera ObtenerCarteleraPorId(int id)
        {

            return RepositorioManager.Carteleras.ObtenerCarteleraPorId(id);

        }

    }
}