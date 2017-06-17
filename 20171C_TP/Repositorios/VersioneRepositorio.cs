using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class VersioneRepositorio : RepositorioBase
    {

        public VersioneRepositorio(TPEntities ctx): base(ctx)
        {
            
        }

        internal List<Versione> ObtenerListaDeVersiones()
        {

            return MiContexto.Versiones.ToList();

        }


    }
}