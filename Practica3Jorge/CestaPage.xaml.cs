using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Practica3Jorge;

public partial class CestaPage : ContentPage
{
    public ObservableCollection<ArticuloAgrupado> Carrito => CarritoManager.CarritoAgrupado;

    public decimal Total => CarritoManager.Carrito.Sum(a => a.Precio);


    public bool IsCarritoVacio => CarritoManager.Carrito.Count == 0;
    public bool IsCarritoLleno => CarritoManager.Carrito.Count > 0;

    public CestaPage()
    {
        InitializeComponent();
        BindingContext = this;

        // Escuchar cambios en el carrito
        CarritoManager.Carrito.CollectionChanged += (s, e) =>
        {
            OnPropertyChanged(nameof(Carrito));
            OnPropertyChanged(nameof(IsCarritoVacio));
            OnPropertyChanged(nameof(IsCarritoLleno));
            OnPropertyChanged(nameof(Total));
        };
    }
    private async void OnPagarClicked(object sender, EventArgs e)
    {
        if (Carrito == null || Carrito.Count == 0)
        {
            await DisplayAlert("Carrito vac�o", "No hay productos en el carrito para pagar.", "OK");
            return;
        }

        // Mostrar un mensaje de agradecimiento
        await DisplayAlert("Pagar", "Gracias por tu compra. Estamos procesando tu pedido.", "OK");

        // Vaciar el carrito
        CarritoManager.VaciarCarrito();

        // Asegurarte de notificar a la interfaz que se vaci� el carrito
        OnPropertyChanged(nameof(Carrito)); // Si est�s usando `INotifyPropertyChanged`
        OnPropertyChanged(nameof(Total));   // Para que el total tambi�n se actualice

        // Alternativa si est�s usando un BindingContext
        BindingContext = null;
        BindingContext = this;
    }


}
