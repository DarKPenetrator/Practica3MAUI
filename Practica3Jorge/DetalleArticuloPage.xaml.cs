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
        BindingContext = this;
        MostrarDatos(); // Mostrar los datos por defecto
    }

    private void MostrarDatos()
    {
        TabContent.Content = new VerticalStackLayout
        {
            Padding = 10,
            Children =
            {

                new Label { Text = $"{Articulo?.Nombre}",  FontSize = 20, FontAttributes = FontAttributes.Bold ,TextColor = Colors.Wheat,HorizontalOptions = LayoutOptions.Center, // Centrar horizontalmente el contenedor
                HorizontalTextAlignment = TextAlignment.Center},
                new Image
            {
                Source = Articulo?.Imagen,
                HeightRequest = 200,
                HorizontalOptions = LayoutOptions.Center
            },
                new Label { Text = $"Descripción: {Articulo?.Descripcion}", FontSize = 16,TextColor = Colors.Wheat,HorizontalOptions = LayoutOptions.Center,  },
                new Label { Text = $"Precio: {Articulo?.Precio:C}", FontSize = 16, TextColor = Colors.Green,HorizontalOptions = LayoutOptions.Center, // Centrar horizontalmente el contenedor
                HorizontalTextAlignment = TextAlignment.Center }
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
        var datosButton = (Button)sender; // El botón "Datos"
        var opinionesButton = (Button)FindByName("OpinionesButton"); // Buscar el botón "Opiniones"

        // Cambiar colores
        datosButton.BackgroundColor = Color.FromArgb("#FFA500"); // Naranja
        opinionesButton.BackgroundColor = Colors.LightBlue; // Azul claro

        // Mostrar datos
        MostrarDatos();
    }

    private void OnOpinionesTabClicked(object sender, EventArgs e)
    {
        var opinionesButton = (Button)sender; // El botón "Opiniones"
        var datosButton = (Button)FindByName("DatosButton"); // Buscar el botón "Datos"

        // Cambiar colores
        opinionesButton.BackgroundColor = Color.FromArgb("#FFA500"); // Naranja
        datosButton.BackgroundColor = Colors.LightBlue; // Azul claro

        // Mostrar opiniones
        MostrarOpiniones();
    }








}
