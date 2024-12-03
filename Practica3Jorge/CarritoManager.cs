using System.Collections.ObjectModel;
using System.Linq;
using Practica3Jorge.Models;

namespace Practica3Jorge;

public static class CarritoManager
{
    public static ObservableCollection<Articulo> Carrito { get; private set; } = new ObservableCollection<Articulo>();

    public static void AgregarArticulo(Articulo articulo)
    {
        Carrito.Add(articulo);
    }

    public static decimal ObtenerTotal()
    {
        return Carrito.Sum(a => a.Precio);
    }

    // NUEVO: Método para obtener la cantidad de artículos en el carrito
    public static int ObtenerCantidadArticulos()
    {
        return Carrito.Count;
    }
}
