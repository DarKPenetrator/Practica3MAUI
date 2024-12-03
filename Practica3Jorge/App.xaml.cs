using System.Globalization;

namespace Practica3Jorge
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES"); // España
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

            MainPage = new AppShell();
        }
    }
}
