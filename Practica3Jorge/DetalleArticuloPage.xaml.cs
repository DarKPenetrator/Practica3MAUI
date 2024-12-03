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
        InitializeComponent(); // Vincula XAML y código
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
                new Label { Text = $"Descripción: {Articulo?.Descripcion}", FontSize = 16 },
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
                new Label { Text = "Opinión 1: Excelente producto.", FontSize = 16 },
                new Label { Text = "Opinión 2: Muy útil.", FontSize = 16 },
                new Label { Text = "Opinión 3: Lo recomiendo.", FontSize = 16 }
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
