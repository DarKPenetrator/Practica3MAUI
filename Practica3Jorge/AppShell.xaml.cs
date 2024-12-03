namespace Practica3Jorge
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("DetalleArticuloPage", typeof(DetalleArticuloPage));

        }
    }
}
