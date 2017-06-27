﻿using _20171C_TP.Controllers;
using _20171C_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class TiposDocumentosServicio : ControllerBase
    {

        public static TiposDocumentosServicio tiposDocumentosServicio = new TiposDocumentosServicio();

        public List<TiposDocumento> ObtenerListaDeTipos()
        {

            return RepositorioManager.Documentos.ObtenerListaDeTipos();

        }

    }
}