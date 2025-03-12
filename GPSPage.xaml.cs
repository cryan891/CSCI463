using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class GPSPage : ContentPage
    {
        private int currentMapIndex = 2;
        public GPSPage()
        {
            InitializeComponent();
        }
        private void OnImageTapped(object sender, TappedEventArgs e)
        {
            var touchPoint = e.GetPosition((VisualElement)sender);

            if (touchPoint != null)
            {
                Marker.IsVisible = true;
                // Adjust position to center the marker
                double size = CircleSizeSlider.Value;
                Marker.WidthRequest = size;
                Marker.HeightRequest = size;
                Marker.CornerRadius = size / 2;

                AbsoluteLayout.SetLayoutBounds(Marker,
                    new Rect(touchPoint.Value.X - size / 2, touchPoint.Value.Y - size / 2, size, size));
            }
        }

        // Update circle size using slider
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (Marker.IsVisible)
            {
                double size = e.NewValue;
                Marker.WidthRequest = size;
                Marker.HeightRequest = size;
                Marker.CornerRadius = size / 2;

                Rect currentBounds = AbsoluteLayout.GetLayoutBounds(Marker);
                AbsoluteLayout.SetLayoutBounds(Marker,
                    new Rect(currentBounds.X + currentBounds.Width / 2 - size / 2,
                             currentBounds.Y + currentBounds.Height / 2 - size / 2,
                             size, size));
            }
        }
        private void OnUpdateGpsMapClicked(object sender, EventArgs e)
        {
            currentMapIndex++;
            if (currentMapIndex > 3)
            {
                currentMapIndex = 2;
            }
            //idk man this is  good enough  I think
            GpsImage.Source = $"gps_img{currentMapIndex}.png";
        }
    }
}
