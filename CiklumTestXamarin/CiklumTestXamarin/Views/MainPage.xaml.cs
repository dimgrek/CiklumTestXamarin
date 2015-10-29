using CiklumTestXamarin.ViewModels;
using Xamarin.Forms;

namespace CiklumTestXamarin.Views
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _vm;

        public MainPage()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            BindingContext = _vm;
        }
    }
}
