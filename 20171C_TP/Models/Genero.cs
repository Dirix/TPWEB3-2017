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
    
    public partial class Genero
    {
        public Genero()
        {
            this.Peliculas = new HashSet<Pelicula>();
        }
    
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}