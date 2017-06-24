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

                    pelicula.FechaCarga = new DateTime(2014, 4, 4);
                    MiContexto.Peliculas.Add(pelicula);
                    MiContexto.SaveChanges();
                    

                }

                internal void EditarPelicula(Pelicula pelicula)
                {


   

                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).Nombre = pelicula.Nombre;


                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).Descripcion = pelicula.Descripcion;
                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).Imagen = pelicula.Imagen;
                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).IdCalificacion = pelicula.IdCalificacion;
                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).IdGenero = pelicula.IdGenero;
                    MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == pelicula.IdPelicula).Duracion = pelicula.Duracion;

                    MiContexto.SaveChanges();


                }

                internal Pelicula ObtenerPeliculaPorId(int id)
                {

                    return MiContexto.Peliculas.FirstOrDefault(e => e.IdPelicula == id);

                }



                internal List<Pelicula> ObtenerListaDePeliculas()
                {

                    return MiContexto.Peliculas.ToList();

                }
    }
}