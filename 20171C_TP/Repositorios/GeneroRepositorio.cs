using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class GeneroRepositorio : RepositorioBase
    {
        public GeneroRepositorio(TPEntities ctx): base(ctx)
        {
    
        }

        internal List<Genero> ObtenerListaDeGeneros()
        {
            return MiContexto.Generos.ToList();

        }

        internal string ObtenerGeneroPorId(int MiId)
        {
            return MiContexto.Generos.FirstOrDefault(e=>e.IdGenero==MiId).Nombre;

        }

    }
}