namespace c_sharp_fundamentals;

internal class Parsing
{
    internal static void Run()
    {
        int number;
        string userInput = Console.ReadLine()!;

        number = int.Parse(userInput);

        Console.WriteLine($"You entered -> {number}");
    }
}