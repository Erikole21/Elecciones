using Elecciones.Datos;
using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Candidatos = Repositorio.GetCandidatos();
            AsignarIdsPublicidad();
        }

        private void AsignarIdsPublicidad()
        {
            if (Device.RuntimePlatform == Device.iOS)
                IdBanner = "ca-app-pub-2325431808910219/2930234497";
            else if (Device.RuntimePlatform == Device.Android)
                IdBanner = "ca-app-pub-2325431808910219/6021563589";
            else if (Device.RuntimePlatform == Device.UWP)
                IdBanner = "1100018256";
        }

        private List<Candidato> candidatos;

        public List<Candidato> Candidatos
        {
            get { return candidatos; }
            set
            {
                candidatos = value;
                OnPropertyChanged("Candidatos");
            }
        }

        private string idBanner;

        public string IdBanner
        {
            get { return idBanner; }
            set
            {
                idBanner = value;
                OnPropertyChanged("IdBanner");
            }
        }

    }
}
