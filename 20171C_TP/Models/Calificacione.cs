
//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace _20171C_TP.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Calificacione
{

    public Calificacione()
    {

        this.Peliculas = new HashSet<Pelicula>();

    }


    public int IdCalificacion { get; set; }

    public string Nombre { get; set; }



    public virtual ICollection<Pelicula> Peliculas { get; set; }

}

}
