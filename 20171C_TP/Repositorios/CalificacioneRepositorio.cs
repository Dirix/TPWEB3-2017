using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class CalificacioneRepositorio : RepositorioBase
    {
        public CalificacioneRepositorio(TPEntities ctx): base(ctx)
        {
            
        }

        internal List<Calificacione> ObtenerListaDeCalifaciones()
        {
            return MiContexto.Calificaciones.ToList();

        }

        internal string ObtenerCalificacionPorId(int MiId)
        {
            return MiContexto.Calificaciones.FirstOrDefault(e => e.IdCalificacion == MiId).Nombre;

        }
    }
}