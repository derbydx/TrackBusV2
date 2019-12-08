using System;
using System.Collections.Generic;
using TrackBusV2.ViewModels;
using Xamarin.Forms;

namespace TrackBusV2.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
    }
}
