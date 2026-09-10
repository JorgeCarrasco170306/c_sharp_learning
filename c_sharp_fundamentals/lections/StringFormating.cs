public class StringFormating
{
    public static void Run()
    {
        string name = "Jorge";
        string girl = "Kiara";

        string result = "my name is {0} and my girl's name is {1}";

        System.Console.WriteLine(result, name, girl);
    }
}