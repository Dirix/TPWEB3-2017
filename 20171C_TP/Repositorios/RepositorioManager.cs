using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Repositorios
{
    public class RepositorioManager
    {
        public UsuarioRepositorio Usuarios { get; set;}
        public PeliculaRepositorio Peliculas { get; set; }
        public CalificacioneRepositorio Calificaciones { get; set; }
        public GeneroRepositorio Generos { get; set; }
        public SedeRepositorio Sedes { get; set; }
        public ReservaRepositorio Reservas { get; set; }
        public CarteleraRepositorio Carteleras { get; set; }

        public RepositorioManager()
        {
            var ctx = new TPEntities();
            Usuarios = new UsuarioRepositorio(ctx);
            Peliculas = new PeliculaRepositorio(ctx);
            Calificaciones = new CalificacioneRepositorio(ctx);
            Sedes = new SedeRepositorio(ctx);
            Reservas = new ReservaRepositorio(ctx);
            Carteleras = new CarteleraRepositorio(ctx);
        }

    }
}