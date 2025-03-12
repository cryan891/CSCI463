using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace MauiApp1
{
    public partial class VehiclePage : ContentPage
    {
        private bool isCarStarted = false;
        private bool areDoorsLocked = true;
        private bool isTrunkOpen = false;
        private bool areWindowsOpen = false;
        private bool isSunroofOpen = false;

        public VehiclePage()
        {
            InitializeComponent();
        }
        //bleh
        private async void OnStartCarClicked(object sender, EventArgs e)
        {
            isCarStarted = !isCarStarted;
            ((Button)sender).Text = isCarStarted ? "Stop Car" : "Start Car";
            await DisplayAlert("Car Status", isCarStarted ? "Car Started!" : "Car Stopped!", "OK");
        }

        private async void OnDoorLockClicked(object sender, EventArgs e)
        {
            areDoorsLocked = !areDoorsLocked;
            ((Button)sender).Text = areDoorsLocked ? "Unlock Doors" : "Lock Doors";
            await DisplayAlert("Door Status", areDoorsLocked ? "Doors Locked!" : "Doors Unlocked!", "OK");
        }

        private async void OnTrunkClicked(object sender, EventArgs e)
        {
            isTrunkOpen = !isTrunkOpen;
            ((Button)sender).Text = isTrunkOpen ? "Close Trunk" : "Open Trunk";
            await DisplayAlert("Trunk Status", isTrunkOpen ? "Trunk Opened!" : "Trunk Closed!", "OK");
        }

        private async void OnWindowClicked(object sender, EventArgs e)
        {
            areWindowsOpen = !areWindowsOpen;
            ((Button)sender).Text = areWindowsOpen ? "Close Windows" : "Open Windows";
            await DisplayAlert("Window Status", areWindowsOpen ? "Windows Opened!" : "Windows Closed!", "OK");
        }

        private async void OnSunroofClicked(object sender, EventArgs e)
        {
            isSunroofOpen = !isSunroofOpen;
            ((Button)sender).Text = isSunroofOpen ? "Close Sunroof" : "Open Sunroof";
            await DisplayAlert("Sunroof Status", isSunroofOpen ? "Sunroof Opened!" : "Sunroof Closed!", "OK");
        }

        private async void OnClimateClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ClimateControlPage");
        }

        private async void OnGPSClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("GPSNavigation");
        }

        private void CheckFuelClicked(object sender, EventArgs e)
        {
            DisplayAlert("Check Fuel/Battery", "Fuel is at  70% capacity, Battery is fully charged", "OK");
        }

        private async void OnJournalClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("JournalPage");
        }

        private async void OnSecurityClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SecurityPage");
        }
    }
}