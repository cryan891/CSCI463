using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiApp1
{
    public partial class JournalPage : ContentPage
    {
        public JournalPage()
        {
            InitializeComponent();
            LoadActivityData();
        }

        private void LoadActivityData()
        {
            var todayActivities = new List<string> { "Started the car", "Locked doors", "Checked fuel/battery", "Climate control adjusted", };
            var lastWeekActivities = new List<string> { "Opened trunk", "Started the car", "Climate control adjusted", "Started the car", "Locked doors", "Checked fuel/battery", "Climate control adjusted"};
            var lastMonthActivities = new List<string> { "Security alert triggered", "Car serviced", "Started the car", "Climate control adjusted", "Started the car"};
            var longTermActivities = new List<string> { "Car serviced", "Battery replaced", "Oil changed", "Security alert triggered"};
            // Load data into Pickers
            TodayPicker.ItemsSource = todayActivities;
            LastWeekPicker.ItemsSource = lastWeekActivities;
            LastMonthPicker.ItemsSource = lastMonthActivities;
            LongTermPicker.ItemsSource = longTermActivities;
        }

        private void OnActivitySelected(object sender, EventArgs e)
        {
            if (sender is Picker picker && picker.SelectedItem != null)
            {
                DisplayAlert("Activity Selected", $"You selected: {picker.SelectedItem}", "OK");
            }
        }
    }
}
