public class ConsoleCalculator
{
    internal static void Run()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Sum -> {a + b} ");
        Console.WriteLine($"Rest -> {a - b} ");
        Console.WriteLine($"Div -> {a / b} ");
        Console.WriteLine($"Mult -> {a * b} ");
    }
}