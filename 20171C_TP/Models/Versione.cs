
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
    
public partial class Versione
{

    public Versione()
    {

        this.Carteleras = new HashSet<Cartelera>();

        this.Reservas = new HashSet<Reserva>();

    }


    public int IdVersion { get; set; }

    public string Nombre { get; set; }



    public virtual ICollection<Cartelera> Carteleras { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; }

}

}
