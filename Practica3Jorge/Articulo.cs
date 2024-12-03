namespace Practica3Jorge.Models;

public class Articulo
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string Imagen { get; set; }
    public List<string> Opiniones { get; set; } // Lista de opiniones

    // Constructor para inicializar el artículo
    public Articulo(string nombre, string descripcion, decimal precio, string imagen, List<string> opiniones = null)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Imagen = imagen;
        Opiniones = opiniones ?? new List<string>(); // Inicializa una lista vacía si no se pasa una
    }

    // Constructor vacío para flexibilidad
    public Articulo() { }
}
