using RelativeSourcePlayground.Models;
using RelativeSourcePlayground.ViewModels;
using Xamarin.Forms;

namespace RelativeSourcePlayground.Views
{
    public partial class RelativeSourceFindAncestorView : ContentPage
    {
        public RelativeSourceFindAncestorView()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<RelativeSourceViewModel, Drink>(this, "dialog", async (sender, arg) =>
            {
                await DisplayAlert("Buy", arg.Title, "OK");
            });
        }
    }
}