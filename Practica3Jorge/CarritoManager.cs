using System.Collections.ObjectModel;
using System.Linq;
using Practica3Jorge.Models;

namespace Practica3Jorge;

public static class CarritoManager
{
    private static ObservableCollection<Articulo> _carrito = new ObservableCollection<Articulo>();

    public static ObservableCollection<ArticuloAgrupado> CarritoAgrupado
    {
        get
        {
            var agrupado = _carrito
                .GroupBy(a => a.Nombre)
                .Select(g => new ArticuloAgrupado
                {
                    Articulo = g.First(),
                    Cantidad = g.Count()
                });

            return new ObservableCollection<ArticuloAgrupado>(agrupado);
        }
    }

    public static ObservableCollection<Articulo> Carrito => _carrito;

    public static void AgregarArticulo(Articulo articulo)
    {
        _carrito.Add(articulo);
    }

    public static void EliminarArticulo(Articulo articulo)
    {
        _carrito.Remove(articulo);
    }

    public static int ObtenerCantidadArticulos()
    {
        return Carrito.Count;
    }

    public static void VaciarCarrito()
    {
        _carrito.Clear();
    }

}

public class ArticuloAgrupado
{
    public decimal TotalPorGrupo => Cantidad * Articulo.Precio;

    public Articulo Articulo { get; set; }
    public int Cantidad { get; set; }
}
