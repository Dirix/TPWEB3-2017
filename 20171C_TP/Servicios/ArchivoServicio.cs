
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Servicios
{


    public class ArchivoServicio:Controller
    {
        /* ANulado
        public static ArchivoServicio archivoServicio = new ArchivoServicio();

        public string SubirImagen(HttpPostedFileBase file)
        {

            string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file.FileName).ToLower();

            string directorio = "~/Upload/Imagenes/" + archivo;

            

            //file.SaveAs(Server.MapPath("~/Upload/Imagenes/asd.jpg"));
            file.SaveAs("C:/TEST.jpg");

            return directorio; //Retornamos la URL

        }
         */

    }
}