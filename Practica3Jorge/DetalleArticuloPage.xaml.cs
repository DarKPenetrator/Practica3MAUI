using Microsoft.Maui.Controls;
using Practica3Jorge.Models; // Importar clase Articulo

namespace Practica3Jorge;

[QueryProperty(nameof(Articulo), "articulo")]
public partial class DetalleArticuloPage : ContentPage
{
    private Articulo _articulo;
    public Articulo Articulo
    {
        get => _articulo;
        set
        {
            _articulo = value;
            BindingContext = _articulo;
            MostrarDatos();// Vincula los datos del producto
        }
    }

    public DetalleArticuloPage()
    {
        InitializeComponent(); // Vincula XAML y c�digo
        MostrarDatos(); // Mostrar los datos por defecto
    }

    private void MostrarDatos()
    {
        TabContent.Content = new VerticalStackLayout
        {
            Padding = 10,
            Children =
            {
                new Label { Text = "Datos del producto", FontSize = 20, FontAttributes = FontAttributes.Bold },  new Image
            {
                Source = Articulo?.Imagen,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center
            },
                new Label { Text = $"Nombre: {Articulo?.Nombre}", FontSize = 16 },
                new Label { Text = $"Descripci�n: {Articulo?.Descripcion}", FontSize = 16 },
                new Label { Text = $"Precio: {Articulo?.Precio:C}", FontSize = 16, TextColor = Colors.Green }
            }
        };
    }

    private void MostrarOpiniones()
    {
        TabContent.Content = new VerticalStackLayout
        {
            Padding = 10,
            Children =
            {
                new Label { Text = "Opiniones", FontSize = 20, FontAttributes = FontAttributes.Bold },
                new Label { Text = "Opini�n 1: Excelente producto.", FontSize = 16 },
                new Label { Text = "Opini�n 2: Muy �til.", FontSize = 16 },
                new Label { Text = "Opini�n 3: Lo recomiendo.", FontSize = 16 }
            }
        };
    }

    private void OnDatosTabClicked(object sender, EventArgs e)
    {
        MostrarDatos();
    }

    private void OnOpinionesTabClicked(object sender, EventArgs e)
    {
        MostrarOpiniones();
    }
}
