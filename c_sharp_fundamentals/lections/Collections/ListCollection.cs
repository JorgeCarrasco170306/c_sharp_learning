using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Collections
{
    public class ListCollection
    {

        public static void Run()
        {

            List<string> nombres = ["Jorge", "Kiara", "Ana", "Gabriel", "Beatriz", "Carlos"];
            bool existe = nombres.Contains("Carlos");
            nombres.Remove("Beatriz");
            nombres.ForEach(x => Console.WriteLine(x));
        }
    }
}