namespace MauiApp1
{
    public partial class SettingsPage : ContentPage
    {
        private bool isNotificationsOn = false;
        private bool isNightModeOn = false;

        public SettingsPage()
        {
            InitializeComponent();
        }


        private async void OnSearchForUpdate(object sender, EventArgs e)
        {
            await DisplayAlert("Update Check", "App fully updated", "OK");
        }


        private void OnNotificationsToggled(object sender, EventArgs e)
        {
            isNotificationsOn = !isNotificationsOn;

            NotificationsButton.Text = isNotificationsOn ? "Notifications: On" : "Notifications: Off";
            NotificationsButton.BackgroundColor = isNotificationsOn ? Colors.Green : Colors.LightGray;
            TestNotification.BackgroundColor = isNotificationsOn ? Colors.Blue : Colors.Transparent;
            DisplayAlert("Notifications", $"Notifications are {(isNotificationsOn ? "On" : "Off")}", "OK");
        }

        private void ShowNotification()
        {
            NotificationFrame.IsVisible = true; 
        }
        private async void HideNotification()
        {
            await Task.Delay(3000);  
            NotificationFrame.IsVisible = false; 
        }
        private void OnTestNotificationClicked(object sender, EventArgs e)
        {
            ShowNotification();
            HideNotification();
        }

        private void OnNightModeToggled(object sender, EventArgs e)
        {
            isNightModeOn = !isNightModeOn;

            NightModeButton.Text = isNightModeOn ? "Night Mode: On" : "Night Mode: Off";
            NightModeButton.BackgroundColor = isNightModeOn ? Colors.Green : Colors.LightGray;

            if (Application.Current?.UserAppTheme != null)
            {
                if (isNightModeOn)
                {
                    Application.Current.UserAppTheme = AppTheme.Dark;

                }
                else
                {
                    Application.Current.UserAppTheme = AppTheme.Light;

                }

                DisplayAlert("Night Mode", $"Night Mode is {(isNightModeOn ? "On" : "Off")}", "OK");
            }
        }

        //P sure  this is all I need
        private async void OnResetClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Reset Settings", "Are you sure you want to reset to default settings?", "Yes", "No");
            if (Application.Current?.UserAppTheme != null)
            { 
            if (confirm)
            {
                isNotificationsOn = false;
                isNightModeOn = false;

                NotificationsButton.Text = "Notifications: Off";
                NotificationsButton.BackgroundColor = Colors.LightGray;
                    TestNotification.BackgroundColor = Colors.Transparent;
                NightModeButton.Text = "Night Mode: Off";
                NightModeButton.BackgroundColor = Colors.LightGray;

                Application.Current.UserAppTheme = AppTheme.Light;

                await DisplayAlert("Reset", "Settings have been reset to default.", "OK");
            }
            }
        }
    }
}
