using System;
using System.Dynamic;
using System.Windows.Input;
using TrackBusV2.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TrackBusV2.ViewModels
{
    public class RegisterPageViewModel : BaseViewModel
    {

        #region Propiedades
        private string nombre;
        public string Nombre
        {
            get { return nombre; }

            set { SetProperty(ref nombre, value, "Nombre"); }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value, "Email"); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value, "Password"); }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { SetProperty(ref telefono, value, "Telefono"); }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { SetProperty(ref direccion, value, "Direccion"); }
        }

        private string ciudad;
        public string Ciudad
        {
            get { return ciudad; }
            set { SetProperty(ref ciudad, value, "Ciudad"); }
        }

        private string biografia;
        public string Biografia
        {
            get { return biografia; }
            set { SetProperty(ref biografia, value, "Biografia"); }
        }


        #endregion

        #region Methods
        private void Register()
        {
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Telefono) || string.IsNullOrEmpty(Direccion) || string.IsNullOrEmpty(Ciudad))
            { Application.Current.MainPage.DisplayAlert("Error", "Datos en Blanco", "Ok"); return; }

            Application.Current.MainPage
                .Navigation.PushAsync(new NavigationPage(new MyTabbedPage()));
        }
        #endregion

        public ICommand OnBtnRegister { get; set; }

        public RegisterPageViewModel()

        {
            OnBtnRegister = new Command(Register);
        }
    }

}







