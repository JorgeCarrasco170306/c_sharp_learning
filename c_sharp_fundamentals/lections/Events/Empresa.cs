namespace c_sharp_fundamentals.lections.Events
{
    public class Empresa
    {
        public event EventHandler<EmpleadoContratadoEvent>? EmpleadoContratado;

        public void RegistrarNuevoEmpleado(string nombre, string correo, string puesto, int salario)
        {
            Console.WriteLine($"\n--- [SISTEMA] Registrando a {nombre} en la empresa ---");
            var datos = new EmpleadoContratadoEvent(nombre, correo, puesto, salario);

            EmpleadoContratado?.Invoke(this, datos);
        }
    }
}