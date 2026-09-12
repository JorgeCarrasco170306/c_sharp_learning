namespace c_sharp_fundamentals.lections.Collections
{
    public class Dictionary
    {
        public static void Run()
        {
            Dictionary<string, int> inventario = new()
            {
              {"Teclado", 45},
              {"Raton", 50},
            };

            inventario["monitor"] = 200;

            if (inventario.TryGetValue("monitor", out int stock))
            {
                Console.WriteLine($"Stock disponible de monitor -> {stock}");
            }

            bool tenemosTeclado = inventario.ContainsKey("teclado");

            Console.WriteLine(tenemosTeclado);
        }
    }
}