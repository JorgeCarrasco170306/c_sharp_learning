namespace c_sharp_fundamentals.lections.Arrays;

public class ArraysFundamentals
{
    public static void Run()
    {
        int[] numbers = [1, 2, 3, 4, 5];
        int[] numbers1 = new int[5];
        int[] numbers2 = { 3, 2, 1 };

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        foreach (int number in numbers1)
        {
            Console.WriteLine(number);
        }

        foreach (int number in numbers2)
        {
            Console.WriteLine(number);
        }
    }
}