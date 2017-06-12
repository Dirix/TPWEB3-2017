using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _20171C_TP.Repositorios
{
    public class UsuarioRepositorio:RepositorioBase
    {

                public UsuarioRepositorio(TPEntities ctx) : base(ctx)
        {
            
        }


                internal bool Autenticar(Usuario usuario)
                {
                    
                    
             
                    //int MiId = MiContexto.Usuarios.FirstOrDefault(e => e.NombreUsuario == usuario.NombreUsuario).IdUsuario;

                    //if (MiContexto.Usuarios.FirstOrDefault(e => e.IdUsuario == MiId).Password == usuario.Password)
                    //{
                    //    return true;
                    //}

                    //return false;

                    if (false  == MiContexto.Usuarios.Any(e => e.NombreUsuario == usuario.NombreUsuario))
                    {
                        return false;
                    }

                    if (MiContexto.Usuarios.FirstOrDefault(e => e.NombreUsuario == usuario.NombreUsuario).Password == usuario.Password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }



    }
}