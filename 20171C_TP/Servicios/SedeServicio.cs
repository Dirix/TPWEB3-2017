using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class SedeServicio:ControllerBase
    {


        public static SedeServicio sedeServicio = new SedeServicio();

        public void AgregarSede(Sede sede)
        {
            RepositorioManager.Sedes.AgregarSede(sede);

        }

        public List<Sede> ObtenerListaDeSedes()
        {

            return RepositorioManager.Sedes.ObtenerListaDeSedes();

        }

        public Sede ObtenerSedePorId(int id)
        {

           return RepositorioManager.Sedes.ObtenerSedePorId(id);

        }   

        public void EditarSede (Sede sede)
        {

            RepositorioManager.Sedes.EditarSede(sede);

        }   
    }
}