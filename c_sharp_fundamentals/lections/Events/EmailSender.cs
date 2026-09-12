using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_fundamentals.lections.Events
{
    public class EmailSender
    {
        public void EnviarCorreoBienvenida(object? sender, EmpleadoContratadoEvent e)
    {
        Console.WriteLine($"[Email]: Enviando correo a <{e.Correo}> con credenciales de acceso...");
    }
    }
}