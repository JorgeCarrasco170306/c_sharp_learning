using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Methods
{
    public class RefOutIn
    {
        public static void Run()
        {
            int numero = 10;
            Incrementar(ref numero);
            Console.WriteLine(numero);
        }

        //ref 
        static void Incrementar(ref int contador) => contador += 1;

        
    }
}