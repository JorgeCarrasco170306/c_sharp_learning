using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Events
{
    public class Security
    {
        public void RegistrarAcceso(object? sender, EmpleadoContratadoEvent e)
    {
        Console.WriteLine($"[Seguridad]: Rostro e identidad de {e.Nombre} reconocidos. Acceso al edificio autorizado.");
    }
    }
}