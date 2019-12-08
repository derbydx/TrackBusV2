using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TrackBusV2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackBusV2.Views
{
    public partial class ListaRutasPage : ContentPage
    {


        public ListaRutasPage()
        {
            InitializeComponent();
            BindingContext = new ListViewViewModel();



        }
    }
}
