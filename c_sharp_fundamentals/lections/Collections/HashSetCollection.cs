using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Collections
{
    public class HashSetCollection
    {

        public static void Run()
        {

            HashSet<int> codigosValidos = [10, 30, 50];

            bool agregado = codigosValidos.Add(30);
            bool existe = codigosValidos.Contains(300);
        }
    }
}