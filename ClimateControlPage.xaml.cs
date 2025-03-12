using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class ClimateControlPage : ContentPage
    {
        private bool isACOn = false;
        private bool isHeaterOn = false;
        private bool isSeatWarmerOn = false;
        private bool isFrontDefrosterOn = false;
        private bool isBackDefrosterOn = false;

        private int fanSpeed = 0;
        private int temperature = 70;
        private int humidity = 36;

        public ClimateControlPage()
        {
            InitializeComponent();
            UpdateTemperatureLabel();
            UpdateHumidityLabel();
            UpdateFanSpeedGraphic();
            UpdateFanSpeedLabel();
        }

        // Update temperature label
        private void UpdateTemperatureLabel()
        {
            InsideTemperatureLabel.Text = $"{temperature}°F";
            OutsideTemperatureLabel.Text = $"18°F";
        }

        private void UpdateHumidityLabel()
        {
            InsideHumidityLabel.Text = $"{humidity}%";
            OutsideHumidityLabel.Text = $"85%";
        }

        // AC Toggle Handler
        private async void ACToggled(object sender, EventArgs e)
        {
            if (isHeaterOn)
            {
                await DisplayAlert("Conflict", "Turning on the AC will turn off the Heater.", "OK");
                isHeaterOn = false;
                HeaterButton.Text = "Turn Heater On";
            }

            isACOn = !isACOn;
            ACButton.Text = isACOn ? "Turn AC Off" : "Turn AC On";

            if (isACOn && fanSpeed == 0)
            {
                fanSpeed = 1; // Turn fan on if AC is turned on
                UpdateFanSpeedGraphic();
                UpdateFanSpeedLabel();
            }

            await DisplayAlert("AC Control", isACOn ? "AC turned on." : "AC turned off.", "OK");
        }

        // Heater Toggle Handler
        private async void HeaterToggled(object sender, EventArgs e)
        {
            if (isACOn)
            {
                await DisplayAlert("Conflict", "Turning on the Heater will turn off the AC.", "OK");
                isACOn = false;
                ACButton.Text = "Turn AC On";
            }

            isHeaterOn = !isHeaterOn;
            HeaterButton.Text = isHeaterOn ? "Turn Heater Off" : "Turn Heater On";

            if (isHeaterOn && fanSpeed == 0)
            {
                fanSpeed = 1; // Turn fan on if Heater is turned on
                UpdateFanSpeedGraphic();
                UpdateFanSpeedLabel();
            }

            await DisplayAlert("Heater Control", isHeaterOn ? "Heater turned on." : "Heater turned off.", "OK");
        }

        // Fan Speed 
        private void UpdateFanSpeedGraphic()
        {
            foreach (var child in FanSpeedGraphic.Children)
            {
                if (child is BoxView boxView)
                {
                    boxView.Color = Color.FromArgb("#D3D3D3"); // Light Gray 
                }
            }

            // Highlight the appropriate number of BoxViews from the bottom up
            for (int i = 0; i < fanSpeed; i++)
            {
                if (FanSpeedGraphic.Children[FanSpeedGraphic.Children.Count - 1 - i] is BoxView boxView)
                {
                    boxView.Color = Color.FromArgb("#0078D7"); // Blue
                }
            }
        }

        private void FanSpeedUpClicked(object sender, EventArgs e)
        {
            if (fanSpeed == 0)
            {
                fanSpeed = 1;
            }
            else
            {
                fanSpeed = Math.Min(fanSpeed + 1, 5); 
            }
            UpdateFanSpeedLabel();
            UpdateFanSpeedGraphic();
        }

        private void FanSpeedDownClicked(object sender, EventArgs e)
        {
            fanSpeed = Math.Max(fanSpeed - 1, 0);
            UpdateFanSpeedLabel();
            UpdateFanSpeedGraphic();
        }

        private void UpdateFanSpeedLabel()
        {
            FanSpeedLabel.Text = $"Fan Speed: {fanSpeed}";
        }

        // Seat Warmer
        private void SeatWarmerToggled(object sender, EventArgs e)
        {
            isSeatWarmerOn = !isSeatWarmerOn;
            SeatWarmerButton.Text = isSeatWarmerOn ? "Turn Seat Warmer Off" : "Turn Seat Warmer On";
            DisplayAlert("Seat Warmers", isSeatWarmerOn ? "Seat warmer turned on." : "Seat warmer turned off.", "OK");
        }

        // Temperature
        private void TempUpClicked(object sender, EventArgs e)
        {
            temperature = Math.Min(temperature + 1, 85);
            UpdateTemperatureLabel();
        }

        private void TempDownClicked(object sender, EventArgs e)
        {
            temperature = Math.Max(temperature - 1, 60); 
            UpdateTemperatureLabel();
        }

        // Defroster
        private void FrontDefrosterToggled(object sender, EventArgs e)
        {
            isFrontDefrosterOn = !isFrontDefrosterOn;
            FrontDefrosterButton.Text = isFrontDefrosterOn ? "Turn Front Defroster Off" : "Turn Front Defroster On";
            if (isFrontDefrosterOn && fanSpeed == 0)
            {
                fanSpeed = 1; // Turn fan on if Front Defroster is turned on
                UpdateFanSpeedGraphic();
                UpdateFanSpeedLabel();
            }
            DisplayAlert("Front Defroster", isFrontDefrosterOn ? "Front defroster turned on." : "Front defroster turned off.", "OK");
        }

        private void BackDefrosterToggled(object sender, EventArgs e)
        {
            isBackDefrosterOn = !isBackDefrosterOn;
            BackDefrosterButton.Text = isBackDefrosterOn ? "Turn Back Defroster Off" : "Turn Back Defroster On";
            DisplayAlert("Back Defroster", isBackDefrosterOn ? "Back defroster turned on." : "Back defroster turned off.", "OK");
        }
    }
}
