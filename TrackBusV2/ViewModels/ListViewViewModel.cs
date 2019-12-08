using System;
using System.Collections.ObjectModel;

namespace TrackBusV2.ViewModels
{
    public class ListViewViewModel
    {
        public ObservableCollection<Autobus> AutobusList { get; set; }

        public ListViewViewModel()
        {
             AutobusList = new ObservableCollection<Autobus>
            {
                new Autobus(){Chofer="Derby Martinez", Detalle="Ruta UTECO-Cotui",Image="Chofer1.png" },
                new Autobus(){Chofer="Jesus Alberto", Detalle="Ruta UTECO-Fantino",Image="Chofer2.jpg" },

            };
        }
    }

    public class Autobus
    {
        public string Chofer { get; set; }
        public string Detalle { get; set; }
        public string Image { get; set; }
    }
}
