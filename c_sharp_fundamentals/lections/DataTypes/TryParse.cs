namespace c_sharp_fundamentals.lections.DataTypes;

public class TryParse
{
    public static void Run()
    {

        Random random = new();
        int randomNumber = random.Next(1, 11);

        Console.WriteLine("Give me a number between 1 and 10");
        bool isNumber = int.TryParse(Console.ReadLine()!, out int number);

        if (isNumber)
        {
            if (number > 10 || number < 1)
            {
                Console.WriteLine($"number {number} is not in the range");
            }
            else
            {

                bool equals = randomNumber == number ? true : false;
                Console.WriteLine($"Did you guess the number? {equals} \n the random number was {randomNumber} and your answer was {number}");
            }
        }
        else
        {
            Console.WriteLine($"{number} is not a number");
        }

    }
}