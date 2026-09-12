using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.ControlFlow
{
    public class Switch
    {

        public static void Run()
        {

            int dia = 3;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
            }


            // 

            string nombreDia = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miercoles",
                _ => "Dia no valido"
            };

            string categoria = dia switch
            {
                1 or 2 or 3 => "Comenzando la semana",
                4 or 5 or 6 or 7 => "Finalizando la semana",
                _ => "Dia no valido"
            };


            int temperatura = 28;

            string clima = temperatura switch
            {
                < 0 => "Congelando",
                >= 0 and <= 15 => "Frío",
                > 15 and <= 25 => "Agradable",
                > 25 => "Caluroso"
            };

            Persona jorge = new("Jorge", 20, true);

            switch (jorge)
            {
                case { Edad: >= 18 } p when p.TieneLicencia:
                    Console.WriteLine("Puede conducir");
                    break;
                case { Edad: >= 18 }:
                    Console.WriteLine("Mayor de edad sin licencia");
                    break;
                default:
                    Console.WriteLine("Menor de edad");
                    break;
            }
        }
    }
}