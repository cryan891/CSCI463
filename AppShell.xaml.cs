namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("VehiclePage", typeof(MauiApp1.VehiclePage));
            Routing.RegisterRoute("ClimateControlPage", typeof(MauiApp1.ClimateControlPage));
            Routing.RegisterRoute("ListDriversPage", typeof(MauiApp1.DriverListPage));
            Routing.RegisterRoute("GPSNavigation", typeof(MauiApp1.GPSPage));
            Routing.RegisterRoute("SecurityPage", typeof(MauiApp1.SecurityPage));
            Routing.RegisterRoute("JournalPage", typeof(MauiApp1.JournalPage));
            Routing.RegisterRoute("AddDriverPage", typeof(MauiApp1.AddDriverPage));
            Routing.RegisterRoute("DeleteDriverPage", typeof(MauiApp1.DeleteDriverPage));
        }

        private async void OnListDriversClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ListDriversPage");
        }
        private async void OnAddDriverClicked(object sender, EventArgs e)
        {
            // Navigate to the Add Driver page
            await Shell.Current.GoToAsync("AddDriverPage");
        }
        // Navigation for Add Driver
        private void OnManageDriversClicked(object sender, EventArgs e)
        {
            // Do nothing
        }

        // Navigation for Delete Driver
        private async void OnDeleteDriverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("DeleteDriverPage");
        }
    }
}
