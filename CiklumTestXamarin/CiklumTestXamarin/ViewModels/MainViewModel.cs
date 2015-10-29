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
        private string _email;
        private string _lastName;
        private string _name;
        private UserService _us;
        private string _userName;


        public MainViewModel()
        {
            LastName = "Ivanov";
            Name = "Ivan";
            Email = "email";
            UserName = "User Name";
            GetUserCommand = new Command(GetUser);
            _us = new UserService();
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
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
            var result = await _us.GetUser();
            UserName = result.user.email;
            Name = result.user.name.first;
            LastName = result.user.name.last;
            Email = result.user.email;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
