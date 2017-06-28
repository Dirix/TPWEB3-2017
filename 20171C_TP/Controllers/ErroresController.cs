using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20171C_TP.Controllers
{
    public class ErroresController : Controller
    {
        //
        // GET: /Errores/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ErrorDefault()
        {
            return View();
        }

    }
}
