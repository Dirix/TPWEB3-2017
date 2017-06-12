using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _20171C_TP.Models
{
    public class MiContexto : DbContext
    {
        public MiContexto() : base("name=TPEntities") { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}