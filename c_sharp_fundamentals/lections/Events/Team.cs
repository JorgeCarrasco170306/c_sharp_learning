using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Events
{
    public class Team
    {
        public void NotificarSalario(object? sender, EmpleadoContratadoEvent e)
    {
        Console.WriteLine($"[RRHH]: Hola {e.Nombre}, tu contrato estipula un salario de ${e.Salario:N2} mensuales.");
    }
    }
}