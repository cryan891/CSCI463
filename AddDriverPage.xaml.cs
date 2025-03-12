using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class AddDriverPage : ContentPage
    {
        public AddDriverPage()
        {
            InitializeComponent();
        }

        private void OnAddDriverClicked(object sender, EventArgs e)
        {
            // Get the text entered in the Entry fields
            string driverName = DriverNameEntry.Text;
            string vehicleModel = VehicleModelEntry.Text;
            string? vehicleType = VehicleTypePicker.SelectedItem.ToString(); 


            // Simple validation to check if all fields are filled out
            if (string.IsNullOrEmpty(driverName) || string.IsNullOrEmpty(vehicleModel) || string.IsNullOrEmpty(vehicleType))
            {
                DisplayAlert("Error", "Please fill out all fields", "OK");
                return;
            }

            // Create a new Driver object
            Driver newDriver = new Driver(driverName, vehicleModel, vehicleType);
            DriverData.Drivers.Add(newDriver);
            DisplayAlert("Success", $"Driver {driverName} added successfully!", "OK");

            DriverNameEntry.Text = string.Empty;
            VehicleModelEntry.Text = string.Empty;
        }
    }
}