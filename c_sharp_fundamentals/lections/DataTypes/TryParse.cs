using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.DataTypes
{
    public interface TryParse
    {
        public static void Run()
        {
            Console.WriteLine("Give me a number");
            int number = int.Parse(Console.ReadLine()!);


            Console.WriteLine(number);
        }
    }
}