using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_fundamentals
{
    internal class ValueTypes
    {
        internal static void Run()
        {
            sbyte bytePermiteNegativos = 127;
            ushort shortNoPermiteNegativos = 62000;
            uint noNegatives = 4_000_000_000;
            ulong noLongNegative = 16_000_000_000;

            byte b = 255;
            short s  = 32700;
            int i = 2_000_000;
            long l = 3_000_000;

            float f = 3.14f;
            double d = 20.30;
            decimal deci = 30.300M;

            char initial = 'J';

            bool married = true;
            
        }
    }
}
