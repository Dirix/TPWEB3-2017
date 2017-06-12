using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class RepositorioBase
    {

        protected TPEntities MiContexto { get; set; }

        
        public RepositorioBase(TPEntities ctx)
        {
            this.MiContexto = ctx;
        }

    }
}