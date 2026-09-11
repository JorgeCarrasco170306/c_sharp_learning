public class ConversionHelpers
{
    public static void Run()
    {
        string number = "17";
        int result = int.Parse(number);


        string married = "true";

        bool marriedBool = Convert.ToBoolean(married);

        Console.WriteLine(result);
        Console.WriteLine($"married? {marriedBool}");
    }
}