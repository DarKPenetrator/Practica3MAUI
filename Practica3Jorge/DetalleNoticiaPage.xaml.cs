using Microsoft.Maui.Controls;
using Practica3Jorge;

namespace Practica3Jorge
{
    [QueryProperty(nameof(Noticia), "noticia")]
    public partial class DetalleNoticiaPage : ContentPage
    {
        private Noticia _noticia;
        public Noticia Noticia
        {
            get => _noticia;
            set
            {
                _noticia = value;
                BindingContext = _noticia;
            }
        }

        public DetalleNoticiaPage()
        {
            InitializeComponent();
        }
    }
}
