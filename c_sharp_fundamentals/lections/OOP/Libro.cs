namespace c_sharp_fundamentals.lections.OOP;

public class Libro(string nombre, string autor, int cantidadPaginas)
{
    public string Nombre { get; set; } = nombre;
    public string Autor { get; set; } = autor;
    public int CantidadPaginas { get; set; } = cantidadPaginas;


}