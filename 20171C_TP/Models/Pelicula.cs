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
    
    public partial class Pelicula
    {
        public Pelicula()
        {
            this.Carteleras = new HashSet<Cartelera>();
            this.Reservas = new HashSet<Reserva>();
        }
    
        public int IdPelicula { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public int IdCalificacion { get; set; }
        public int IdGenero { get; set; }
        public int Duracion { get; set; }
        public System.DateTime FechaCarga { get; set; }
    
        public virtual Calificacione Calificacione { get; set; }
        public virtual ICollection<Cartelera> Carteleras { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}