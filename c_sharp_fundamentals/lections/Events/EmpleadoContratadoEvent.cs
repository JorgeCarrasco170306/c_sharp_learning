namespace c_sharp_fundamentals.lections.Events
{
    public class EmpleadoContratadoEvent(string nombre, string correo, string puesto, int salario) : EventArgs
    {
        public string Nombre { get; } = nombre;
        public string Correo { get; } = correo;
        public string Puesto { get; } = puesto;
        public int Salario { get; } = salario;
    }
}