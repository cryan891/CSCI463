using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class CameraFeedPopup : ContentPage
    {
        public ICommand CloseCommand { get; }

        public CameraFeedPopup()
        {
            InitializeComponent();
            CloseCommand = new Command(async () => await ClosePopup());
            BindingContext = this;
        }

        private async Task ClosePopup()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}
