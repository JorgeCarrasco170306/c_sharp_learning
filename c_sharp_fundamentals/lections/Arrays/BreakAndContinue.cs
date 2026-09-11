using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Arrays
{
    public class BreakAndContinue
    {
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i is 3)
                {
                    Console.WriteLine("I've had enough");
                    break;
                }
            }
        }
    }
}