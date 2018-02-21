using Elecciones.Datos;
using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Elecciones.ViewModels
{
    public class PropuestasViewModel : ViewModelBase
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

        public PropuestasViewModel(Candidato _candidato)
        {
            this.Candidato = _candidato;
            CargarInformacion();
            AsignarIdsPublicidad();
        }

        private void AsignarIdsPublicidad()
        {
            if (Device.RuntimePlatform == Device.iOS)
                IdBanner = "ca-app-pub-2325431808910219/6922338445";
            else if (Device.RuntimePlatform == Device.Android)
                IdBanner = "ca-app-pub-2325431808910219/4844213284";
            else if (Device.RuntimePlatform == Device.UWP)
                IdBanner = "1100018258";
        }

        private void CargarInformacion()
        {
            this.Propuestas = Repositorio.GetPropuestas(cantidato.Id);
        }

        private List<Propuesta> propuestas;

        public List<Propuesta> Propuestas
        {
            get { return propuestas; }
            set
            {
                propuestas = value;
                OnPropertyChanged("Propuestas");
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
