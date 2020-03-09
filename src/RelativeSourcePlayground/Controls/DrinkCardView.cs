using Xamarin.Forms;

namespace RelativeSourcePlayground.Controls
{
    public class DrinkCardView : ContentView
    {
        public static readonly BindableProperty DrinkTitleProperty = BindableProperty.Create(nameof(DrinkTitle), typeof(string), typeof(DrinkCardView), string.Empty);
        public static readonly BindableProperty DrinkDescriptionProperty = BindableProperty.Create(nameof(DrinkDescription), typeof(string), typeof(DrinkCardView), string.Empty);
        public static readonly BindableProperty DrinkColorProperty = BindableProperty.Create(nameof(DrinkColor), typeof(Color), typeof(DrinkCardView), Color.Default);
        public static readonly BindableProperty DrinkImageSourceProperty = BindableProperty.Create(nameof(DrinkImageSource), typeof(ImageSource), typeof(DrinkCardView), default(ImageSource));

        public string DrinkTitle
        {
            get => (string)GetValue(DrinkTitleProperty);
            set => SetValue(DrinkTitleProperty, value);
        }

        public string DrinkDescription
        {
            get => (string)GetValue(DrinkDescriptionProperty);
            set => SetValue(DrinkDescriptionProperty, value);
        }

        public Color DrinkColor
        {
            get => (Color)GetValue(DrinkColorProperty);
            set => SetValue(DrinkColorProperty, value);
        }

        public ImageSource DrinkImageSource
        {
            get => (ImageSource)GetValue(DrinkImageSourceProperty);
            set => SetValue(DrinkImageSourceProperty, value);
        }
    }
}