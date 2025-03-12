using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class DeleteDriverPage : ContentPage
    {
        // Change selectedDriver to be Driver
        private Driver selectedDriver;

        public DeleteDriverPage()
        {
            InitializeComponent();
            DriversListView.ItemsSource = DriverData.Drivers;
            BindingContext = this;
        }

        public ObservableCollection<Driver> Drivers { get; set; }

        private void OnDriverSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                // Set the selected driver to the actual Driver object, not string
                selectedDriver = (Driver)e.SelectedItem;
            }
        }

        private void OnDeleteDriverClicked(object sender, EventArgs e)
        {
            if (selectedDriver == null)
            {
                DisplayAlert("Error", "Please select a driver to delete", "OK");
                return;
            }

            DriverData.Drivers.Remove(selectedDriver);

            DisplayAlert("Success", $"{selectedDriver.Name} has been deleted", "OK");
            selectedDriver = null;
        }
    }
}
