namespace Practica3Jorge
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

        }

        private async void OnExplorarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///ArticulosPage");
        }



        private async void OnNoticiasClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("NoticiasPage");
        }
    }

}
