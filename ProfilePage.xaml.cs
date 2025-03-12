using Microsoft.Maui.Controls;
using System.Xml;

namespace MauiApp1
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        // Track whether the profile is being edited
        private bool isEditing = false;

        private void OnEditProfileClicked(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Save the new values from Entry fields
                NameLabel.Text = NameEntry.Text;
                EmailLabel.Text = EmailEntry.Text;
                VehicleLabel.Text = VehicleEntry.Text;

                // Make the Entry fields invisible and Labels visible again
                NameLabel.IsVisible = true;
                NameEntry.IsVisible = false;

                EmailLabel.IsVisible = true;
                EmailEntry.IsVisible = false;

                VehicleLabel.IsVisible = true;
                VehicleEntry.IsVisible = false;

                // Change button text to "Edit Profile"
                ((Button)sender).Text = "Edit Profile";
            }
            else
            {
                // Make the Labels invisible and Entry fields visible
                NameLabel.IsVisible = false;
                NameEntry.IsVisible = true;

                EmailLabel.IsVisible = false;
                EmailEntry.IsVisible = true;

                VehicleLabel.IsVisible = false;
                VehicleEntry.IsVisible = true;

                // Change button text to "Save Profile"
                ((Button)sender).Text = "Save Profile";
            }

            // Toggle editing state
            isEditing = !isEditing;
        }
    }
}
