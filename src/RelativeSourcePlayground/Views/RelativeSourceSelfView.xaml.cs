using RelativeSourcePlayground.Models;
using Xamarin.Forms;

namespace RelativeSourcePlayground.Views
{
    public partial class RelativeSourceSelfView : ContentPage
    {
        public RelativeSourceSelfView()
        {
            InitializeComponent();
        }

        public Drink Drink { get; } = new Drink
        {
            Image = "coffee.png",
            Title = "BRAZILIAN COFFEE",
            Color = Color.Maroon,
            Price = 3.5,
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        };
    }
}