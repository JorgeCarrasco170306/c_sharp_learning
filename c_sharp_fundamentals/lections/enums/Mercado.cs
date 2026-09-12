using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.enums
{
    public class Mercado
    {
        public static void Run()
        {
            Orden orden = new("PS5", "Manzana C edificio 11 apto 401", EstadoOrden.PREPARANDO);

            bool entregado = orden.EstadoOrden == EstadoOrden.ENVIADO ? true : false;

            Console.WriteLine($"La orden: {orden.Nombre} esta {orden.EstadoOrden}");
            Console.WriteLine($"Entregado: {entregado}");
        }
    }
}