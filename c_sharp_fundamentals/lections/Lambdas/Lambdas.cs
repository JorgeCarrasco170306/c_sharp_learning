namespace c_sharp_fundamentals.lections.Lambdas
{
    public class Lambdas
    {
        public static void Run()
        {
            Func<int, int> Duplicar = x => x * 2;
            Console.WriteLine(Duplicar(5)); // 10

            Func<int, int, int> Sumar = (a, b) => a + b;
            Console.WriteLine(Sumar(5, 10)); // 15

            Action Saludar = () => Console.WriteLine("!Hola!");
            Saludar();

            Func<int, int, int> OperacionCompleja = (a, b) =>
            {
                int temporal = a * 2;
                int resultado = temporal + b;
                return resultado;
            };

            Console.WriteLine(OperacionCompleja(10, 10));

            Predicate<int> Equals10 = x => x == 10;

            Console.WriteLine(Equals10(10));


            var Multiplicar = (int a, int b) => a * b;

            Console.WriteLine(Multiplicar(10, 30));

        }
    }
}