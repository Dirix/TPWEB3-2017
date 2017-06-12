using _20171C_TP.Controllers;
using _20171C_TP.Models;
using _20171C_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class UsuarioServicio:ControllerBase
    {

        public static UsuarioServicio usuarioServicio = new UsuarioServicio();


        public bool Autenticar(Usuario usuario)
        {

            return RepositorioManager.Usuarios.Autenticar(usuario);
        }

    }
}