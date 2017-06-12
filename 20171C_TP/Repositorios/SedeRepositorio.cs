using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class SedeRepositorio:RepositorioBase
    {
                        public SedeRepositorio(TPEntities ctx) : base(ctx)
        {
            
        }

                        internal void AgregarSede(Sede sede)
                        {

                            MiContexto.Sedes.Add(sede);
                            MiContexto.SaveChanges();


                        }



                        internal List<Sede> ObtenerListaDeSedes()
                        {

                            return MiContexto.Sedes.ToList();

                        }


                        internal void EditarSede(Sede sede)
                        {

                            MiContexto.Sedes.FirstOrDefault(e => e.IdSede == sede.IdSede).Nombre = sede.Nombre;
                            MiContexto.Sedes.FirstOrDefault(e => e.IdSede == sede.IdSede).Direccion = sede.Direccion;
                            MiContexto.Sedes.FirstOrDefault(e => e.IdSede == sede.IdSede).PrecioGeneral = sede.PrecioGeneral;

                            MiContexto.SaveChanges();


                        }

                        internal Sede ObtenerSedePorId(int id)
                        {

                            return MiContexto.Sedes.FirstOrDefault(e => e.IdSede == id);

                        }

    }
}