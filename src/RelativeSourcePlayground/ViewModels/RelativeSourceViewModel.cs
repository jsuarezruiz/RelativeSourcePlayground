using System.Collections.ObjectModel;
using System.Windows.Input;
using RelativeSourcePlayground.Models;
using Xamarin.Forms;

namespace RelativeSourcePlayground.ViewModels
{
    public class RelativeSourceViewModel : BindableObject
    {
        private ObservableCollection<Drink> _drinks;

        public RelativeSourceViewModel()
        {
            LoadDrinks();
        }

        public ObservableCollection<Drink> Drinks
        {
            get { return _drinks; }
            set
            {
                _drinks = value;
                OnPropertyChanged();
            }
        }

        public ICommand BuyCommand => new Command<Drink>(OnBuy);

        void LoadDrinks()
        {
            Drinks = new ObservableCollection<Drink>()
            {
                 new Drink { Image="coffee.png", Title = "BRAZILIAN COFFEE", Color= Color.Maroon, Price =3.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Drink { Image="marshmallows.png", Title = "HOT CHOCOLATE WITH MARSHMALLOWS", Color= Color.Wheat, Price = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Drink { Image="plant.png", Title = "MILK WITH MINT", Color= Color.Green, Price = 7.99, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." },
                 new Drink { Image="strawberry.png", Title = "STRAWBERRY MILK", Color= Color.Red, Price = 6.5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." }
            };
        }

        void OnBuy(Drink drink)
        { 
             MessagingCenter.Send(this, "dialog", drink);
        }
    }
}