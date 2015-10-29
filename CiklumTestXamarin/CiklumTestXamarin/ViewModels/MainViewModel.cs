using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CiklumTestXamarin.Annotations;
using CiklumTestXamarin.Service.UserService;
using Xamarin.Forms;

namespace CiklumTestXamarin.ViewModels
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private string _lastName;
        private string _name;
        private UserService _us;


        public MainViewModel()
        {
            LastName = "Ivanov";
            Name = "Ivan";
            GetUserCommand = new Command(GetUser);
            _us = new UserService();
        }

        public ICommand GetUserCommand { get; private set; }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged(); }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void GetUser()
        {
            var user = await _us.GetUser();
            LastName = user.name.first;
            Name = user.name.last;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
