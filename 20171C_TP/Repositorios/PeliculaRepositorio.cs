using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class PeliculaRepositorio:RepositorioBase
    {
        
                public PeliculaRepositorio(TPEntities ctx) : base(ctx)
        {
            
        }


                internal void AgregarPelicula(Pelicula pelicula)
                {
                    pelicula.Imagen = "Asd";
                    pelicula.FechaCarga = new DateTime(2014, 4, 4);
                    MiContexto.Peliculas.Add(pelicula);
                    MiContexto.SaveChanges();
                    

                }



                internal List<Pelicula> ObtenerListaDePeliculas()
                {

                    return MiContexto.Peliculas.ToList();

                }
    }
}