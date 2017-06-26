using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.DTO
{
    public class SedeDTO
    {
        public int sedeId { get; set; }
        public String nombreSede { get; set; }
        public String direccion { get; set; }
        public decimal precioGeneral { get; set; }
    }
}