namespace c_sharp_fundamentals.lections.OOP
{
    public class OppImpl
    {
        public static void Run()
        {
            Libro libro = new("jorge", "jorge", 20);

            Console.WriteLine(libro.Nombre);
        }
    }
}