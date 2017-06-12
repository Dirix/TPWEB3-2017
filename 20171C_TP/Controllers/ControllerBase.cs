using _20171C_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Controllers
{
    public class ControllerBase : Controller
    {
        //
        // 
        public RepositorioManager RepositorioManager { get; set; }

        public ControllerBase()
        {
            //Instanciamos el repositorioManager para que el mismo sea heredado por los restantes controladores
            RepositorioManager = new RepositorioManager();
        }

    }
}
