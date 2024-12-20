﻿namespace Practica3Jorge
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("DetalleArticuloPage", typeof(DetalleArticuloPage));
            Routing.RegisterRoute("NoticiasPage", typeof(NoticiasPage));
            Routing.RegisterRoute("DetalleNoticiaPage", typeof(DetalleNoticiaPage));

        }




        private async void OnCestaToolbarClicked(object sender, EventArgs e)
        {
            // Navegar a CestaPage
            await Shell.Current.GoToAsync("//CestaPage");
        }
    }
}
