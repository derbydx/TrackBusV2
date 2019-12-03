using System;
using System.Windows.Input;
using TrackBusV2.Views;
using Xamarin.Forms;

namespace TrackBusV2.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string email;
        public string Email
        {
            get { return email; }

            set
            {
                SetProperty(ref email, value, "Email");
            }

        }

        public ICommand OnLogin { get; set; }
        public ICommand OnRegister { get; set; }

        public LoginPageViewModel()
        {
            OnLogin = new Command(Login);
            OnRegister = new Command(Register);

        }

        #region Methods

        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Credenciales Invalidas", "Ok");
                return;
            }
            Application.Current.MainPage
                .Navigation.PushModalAsync(new NavigationPage(new MainPaginaTab()));
        }

        private void Register()
        {
            Application.Current.MainPage
                .Navigation.PushModalAsync(new NavigationPage(new RegisterPage()));
        }


        #endregion

        #region Properties

        private string password;
        public string Password
        {

            get
            {
                return password;
            }

            set
            {
                SetProperty(ref password, value, "Password");
            }
        }

        #endregion

    }
}
