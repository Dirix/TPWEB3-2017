using _20171C_TP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20171C_TP.Servicios
{
    public class FechaServicio : ControllerBase

    {

        public static FechaServicio fechaServicio = new FechaServicio();

    public List<System.DateTime> ObtenerSegunPeriodo(bool lunes, bool martes, bool miercoles,
    bool jueves, bool viernes, bool sabado, bool domingo, List<System.DateTime> ListaDeFechasRecibidas)
        {

            List<System.DateTime> ListaDeFechasNuevas = new List<System.DateTime>();


            /*if (lunes)
                {ListaDeFechasNuevas = new List<System.DateTime>();

                foreach (var i in ListaDeFechasRecibidas)
                    {
                        if (i.DayOfWeek == System.DayOfWeek.Monday)
                            ListaDeFechasNuevas.Add(i);
                    }
                }
            */

            if (lunes)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Monday));
            }

            if (martes)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Tuesday));
            }

            if (miercoles)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Wednesday));
            }

            if (jueves)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Thursday));
            }

            if (viernes)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Friday));
            }
            if (sabado)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Saturday));
            }
            if (domingo)
            {
                ListaDeFechasNuevas.AddRange(ListaDeFechasRecibidas.Where(e => e.DayOfWeek == System.DayOfWeek.Sunday));
            }

            //Ordenamos el listado de fechas final
            ListaDeFechasNuevas = ListaDeFechasNuevas.OrderBy(e => e.Date).ToList();

            return ListaDeFechasNuevas;

        }


    }
}