using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class TiposDocumentoRepositorio : RepositorioBase
    {

        public TiposDocumentoRepositorio(TPEntities ctx)
            : base(ctx)
        {

        }

        internal List<TiposDocumento> ObtenerListaDeTipos()
        {

            return MiContexto.TiposDocumentos.ToList();

        }


    }
}