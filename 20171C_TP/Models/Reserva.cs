//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20171C_TP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int IdSede { get; set; }
        public int IdVersion { get; set; }
        public int IdPelicula { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public string Email { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int CantidadEntradas { get; set; }
        public System.DateTime FechaCarga { get; set; }
    
        public virtual Pelicula Pelicula { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual TiposDocumento TiposDocumento { get; set; }
        public virtual Versione Versione { get; set; }
    }
}
