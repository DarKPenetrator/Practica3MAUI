using Microsoft.Maui.Controls;
using Practica3Jorge.Models;

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
            MostrarDatos(); // Cargar datos por defecto
        }
    }

    public DetalleArticuloPage()
    {
        InitializeComponent();
    }

    private void MostrarDatos()
    {
        // Limpiar contenido previo
        TabContent.Children.Clear();

        // Agregar datos del artículo
        TabContent.Children.Add(new Label
        {
            Text = $"Nombre: {Articulo?.Nombre}",
            FontSize = 20,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.Wheat,
            HorizontalOptions = LayoutOptions.Center
        });

        TabContent.Children.Add(new Image
        {
            Source = Articulo?.Imagen,
            HeightRequest = 175,
            HorizontalOptions = LayoutOptions.Center
        });

        TabContent.Children.Add(new Label
        {
            Text = $"Descripción: {Articulo?.Descripcion}",
            FontSize = 14,
            TextColor = Colors.Wheat,
            HorizontalOptions = LayoutOptions.Start
        });

        TabContent.Children.Add(new Label
        {
            Text = $"Precio: {Articulo?.Precio:N2} ₡",
            FontSize = 16,
            TextColor = Colors.Green,
            HorizontalOptions = LayoutOptions.Start
        });

        TabContent.Children.Add(new Button
        {
            Text = "Agregar al Carrito",
            FontSize = 16,
            BackgroundColor = Color.FromArgb("#FFA500"),
            TextColor = Colors.White,
            CornerRadius = 20,
            Padding = new Thickness(10),
            Margin = new Thickness(0, 20),
            HorizontalOptions = LayoutOptions.Center,
            Command = new Command(() =>
            {
                CarritoManager.AgregarArticulo(Articulo);
                DisplayAlert("Carrito", $"{Articulo.Nombre} añadido al carrito.", "OK");
            })
        });
    }

    private void MostrarOpiniones()
    {
        // Limpiar contenido previo
        TabContent.Children.Clear();

        // Agregar título de opiniones
        TabContent.Children.Add(new Label
        {
            Text = "Opiniones",
            FontSize = 20,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.LightBlue,
            HorizontalOptions = LayoutOptions.Center
        });

        // Agregar opiniones dinámicamente
        if (Articulo.Opiniones != null && Articulo.Opiniones.Any())
        {
            foreach (var opinion in Articulo.Opiniones)
            {
                TabContent.Children.Add(new Frame
                {
                    CornerRadius = 10,
                    BorderColor = Colors.LightGray,
                    Padding = 10,
                    Margin = new Thickness(0, 5),
                    BackgroundColor = Colors.Black,
                    Content = new Label
                    {
                        Text = opinion,
                        FontSize = 16,
                        TextColor = Colors.Wheat
                    }
                });
            }
        }
        else
        {
            TabContent.Children.Add(new Label
            {
                Text = "Este producto aún no tiene opiniones.",
                FontSize = 16,
                TextColor = Colors.Gray,
                HorizontalOptions = LayoutOptions.Center
            });
        }
    }

    private void OnDatosTabClicked(object sender, EventArgs e)
    {
        DatosButton.BackgroundColor = Color.FromArgb("#FFA500");
        OpinionesButton.BackgroundColor = Colors.LightBlue;
        MostrarDatos();
    }

    private void OnOpinionesTabClicked(object sender, EventArgs e)
    {
        OpinionesButton.BackgroundColor = Color.FromArgb("#FFA500");
        DatosButton.BackgroundColor = Colors.LightBlue;
        MostrarOpiniones();
    }
}
