namespace c_sharp_fundamentals.lections.Lambdas
{
    public delegate int Operacion(int a, int b, int c, int d);
    public class Delegates
    {
        public static void Run()
        {
            Operacion operacion = Sumar;
            Console.WriteLine(operacion(10, 20, 30, 50));

            Console.WriteLine(Operar(50, 50, 50, 50, (a, b, c, d) => a * b * c * d));
        }

        public static int Sumar(int a, int b, int c, int d) => a + b + c + d;

        public static int Operar(int a, int b, int c, int d, Operacion operacion)
        {
            return operacion(a, b, c, d);
        }
    }
}