using Microsoft.Maui.Controls;
namespace NovaVersaoCentralDocs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCniTapped(object sender, EventArgs e)
        {
            // sua lógica aqui
            DisplayAlert("Ação", "CNI clicado", "OK");
        }

        // crie os demais handlers similares...
    }
}