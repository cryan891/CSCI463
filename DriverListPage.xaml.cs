using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class DriverListPage : ContentPage
    {
        public DriverListPage()
        {
            InitializeComponent();

            // Set the BindingContext to the DriverData static class
            //I hate  all of this man
            BindingContext = DriverData.Drivers;

        }

    }
}
