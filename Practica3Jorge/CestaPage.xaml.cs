using Microsoft.Maui.Controls;
using Practica3Jorge.Models;
using System.Collections.ObjectModel;

namespace Practica3Jorge;

public partial class CestaPage : ContentPage
{
    public ObservableCollection<Articulo> Carrito => CarritoManager.Carrito;

    public decimal Total => Carrito.Sum(a => a.Precio);

    public bool IsCarritoVacio => Carrito.Count == 0;
    public bool IsCarritoLleno => Carrito.Count > 0;

    public CestaPage()
    {
        InitializeComponent();
        BindingContext = this;

        // Escuchar cambios en el carrito
        Carrito.CollectionChanged += (s, e) =>
        {
            OnPropertyChanged(nameof(IsCarritoVacio));
            OnPropertyChanged(nameof(IsCarritoLleno));
            OnPropertyChanged(nameof(Total));
        };
    }

    private async void OnPagarClicked(object sender, EventArgs e)
    {
        if (Carrito.Count == 0)
        {
            await DisplayAlert("Carrito vacío", "No hay productos en el carrito para pagar.", "OK");
            return;
        }

        // Lógica futura de pago
        await DisplayAlert("Pagar", "Gracias por tu compra. Estamos procesando tu pedido.", "OK");

        // Vaciar el carrito después del pago
        Carrito.Clear();
    }
}
