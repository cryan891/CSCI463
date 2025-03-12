using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class SecurityPage : ContentPage
    {
        private bool _isAlarmActivated = true; 

        public SecurityPage()
        {
            InitializeComponent();
        }

        private async void CamerasButtonClicked(object sender, EventArgs e)
        {
            //This should work
            await Shell.Current.Navigation.PushModalAsync(new CameraFeedPopup());
        }

        private void AlarmButtonClicked(object sender, EventArgs e)
        {
            _isAlarmActivated = !_isAlarmActivated;

            // Update button text + color 
            AlarmButton.Text = _isAlarmActivated ? "Alarm: On" : "Alarm: Off";
            AlarmButton.BackgroundColor = _isAlarmActivated ? Colors.Green : Colors.Red;
        }
    }
}