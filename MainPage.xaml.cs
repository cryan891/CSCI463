namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToVehiclePage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("VehiclePage");
        }



    }
}