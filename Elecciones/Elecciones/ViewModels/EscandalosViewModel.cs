using Elecciones.Datos;
using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.ViewModels
{
    public class EscandalosViewModel : ViewModelBase
    {
        private Candidato cantidato;

        public Candidato Candidato
        {
            get { return cantidato; }
            set
            {
                cantidato = value;
                OnPropertyChanged("Candidato");
            }
        }

        public EscandalosViewModel(Candidato _candidato)
        {
            this.Candidato = _candidato;
            CargarInformacion();
            AsignarIdsPublicidad();
        }

        private void AsignarIdsPublicidad()
        {
            if (Device.RuntimePlatform == Device.iOS)
                IdBanner = "ca-app-pub-2325431808910219/5411452825";
            else if (Device.RuntimePlatform == Device.Android)
                IdBanner = "ca-app-pub-2325431808910219/8012677384";
            else if (Device.RuntimePlatform == Device.UWP)
                IdBanner = "1100018387";
        }

        private void CargarInformacion()
        {
            Escandalos = Repositorio.GetEscandalos(cantidato.Id);
        }

        private List<Propuesta> escandalos;

        public List<Propuesta> Escandalos
        {
            get { return escandalos; }
            set
            {
                escandalos = value;
                OnPropertyChanged("Escandalos");
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
