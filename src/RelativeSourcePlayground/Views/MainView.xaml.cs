using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace RelativeSourcePlayground.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            BindingContext = this;
        }

        public ICommand NavigateCommand { get; private set; }
    }
}