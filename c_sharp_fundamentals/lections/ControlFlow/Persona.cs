using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.ControlFlow
{
    public class Persona(string nombre, int edad, bool tieneLicencia)
    {
        public string Nombre { get; set; } = nombre;
        public bool TieneLicencia { get; set; } = tieneLicencia;
        public int Edad { get; set; } = edad;
    }
}