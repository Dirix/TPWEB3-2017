using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.DTO
{
    public class PreReservaDTO
    {

        public int IdPelicula { get; set; }
        public Pelicula pelicula { get; set; }

        public int IdVersion { get; set; }
        public Versione version { get; set; }

        public int IdSede { get; set; }
        public Sede sede { get; set; }
        
        public int HoraInt { get; set; }
        public string HoraString { get; set; }

        public System.DateTime FechaDate { get; set; }
        public string FechaString { get; set; }

        public int idTipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public int Entradas { get; set; }
    }
}