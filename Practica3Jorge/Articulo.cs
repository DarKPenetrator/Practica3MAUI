namespace Practica3Jorge.Models;

public class Articulo
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string Imagen { get; set; }

    // Constructor para inicializar el artículo
    public Articulo(string nombre, string descripcion, decimal precio, string imagen)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Imagen = imagen;
    }

    // Constructor vacío para flexibilidad
    public Articulo() { }
}
