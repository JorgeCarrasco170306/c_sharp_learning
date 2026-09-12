namespace c_sharp_fundamentals.lections.enums
{
    public class Orden(string nombre, string direccion, EstadoOrden estadoOrden)
    {
        public string Nombre { get; } = nombre;
        public string Direccion { get; } = direccion;
        public EstadoOrden EstadoOrden { get; } = estadoOrden;

        public Orden() : this(string.Empty, string.Empty, default)
        {
        }
    }
}