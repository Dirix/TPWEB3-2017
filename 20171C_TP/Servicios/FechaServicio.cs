using _20171C_TP.Controllers;
using _20171C_TP.DTO;
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

    public List<System.DateTime> FiltrarFechasRepetidas(List<System.DateTime> Fechas)
    {

                   //No repetimos los dias


        List<System.DateTime> ListadoDeFechas = new List<System.DateTime>();
        List<System.DateTime> ResultadoFechas = new List<System.DateTime>();
       
            //var DistinctFechas = from Date in ListaDeFechas
            //            select Date;


            foreach (System.DateTime i in Fechas)
            {
            ListadoDeFechas.Add(i.Date);
            }


            IEnumerable<System.DateTime> FechasNoRepetidas = ListadoDeFechas.Distinct();



            foreach (System.DateTime i in FechasNoRepetidas)
            {
                ResultadoFechas.Add(i.Date);


            }
            
            

        
            return ResultadoFechas;

        }

    public List<System.DateTime> AgregarHora(List<System.DateTime> Fechas, int HoraInicio)
    {



        List<System.DateTime> ListadoFechasSinHora = new List<System.DateTime>();
        List<System.DateTime> ListadoFechasConHora = new List<System.DateTime>();

        foreach (System.DateTime i in Fechas)
        {
            ListadoFechasSinHora.Add(i.Date);
        }

        int cantidadFechas = ListadoFechasSinHora.Count();

        for (int i = 0; i < cantidadFechas; i++)
        {
            ListadoFechasConHora.Add(ListadoFechasSinHora.ElementAt(i).AddHours(HoraInicio));

        }



        return ListadoFechasConHora;

    }

    public List<string> ConvertirAString(List<System.DateTime> Fechas)
        {
            List<string> FechasEnString = new List<string>();

            foreach (var i in Fechas)
             {
                 FechasEnString.Add(i.ToShortDateString() + " " + i.DayOfWeek);

             }

            return FechasEnString;

        }

    public System.DateTime ConvertirAFecha(String FechaString)
    {


            int dia = Convert.ToInt32(FechaString.Substring(0, 2));

            string test = FechaString.Substring(3, 2);

            int mes = Convert.ToInt32(FechaString.Substring(3, 2));
            int ano = Convert.ToInt32(FechaString.Substring(6, 4));
           

            return new DateTime(ano, mes, dia);

    }

    public List<HoraDTO> ConvertirHoraAString(List<System.DateTime> Horarios)
    {
        List<HoraDTO> ListaHorarios = new List<HoraDTO>();

        foreach (var i in Horarios)
        {
            HoraDTO ObjetoHora = new HoraDTO();

            ObjetoHora.HoraInt = i.Hour;
            ObjetoHora.HoraString = i.ToShortTimeString();

            ListaHorarios.Add(ObjetoHora);

        }

        return ListaHorarios;

    }

    }
}