﻿using System;
using System.Collections.Generic;
using System.Text;
using Elecciones.Datos;
using Elecciones.Modelos;
using Xamarin.Forms;

namespace Elecciones.ViewModels
{
    public class DetalleViewModel : ViewModelBase
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

        public DetalleViewModel(Candidato _candidato)
        {
            this.Candidato = _candidato;
            CargarInformacion();
            AsignarIdsPublicidad();
        }

        private void AsignarIdsPublicidad()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                IdBanner = "ca-app-pub-2325431808910219/4344276564";
                IdBannerCargos = "ca-app-pub-2325431808910219/4541347999";
                IdBannerEstudios = "ca-app-pub-2325431808910219/5358292564";
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                IdBanner = "ca-app-pub-2325431808910219/4297418371";
                IdBannerEstudios = "ca-app-pub-2325431808910219/7597443093";
                IdBannerCargos = "ca-app-pub-2325431808910219/9601677956";
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                IdBanner = "1100018257";
                IdBannerEstudios = "1100018336";
                IdBannerCargos = "1100018337";
            }
        }

        private void CargarInformacion()
        {
            Detalle detalle = Repositorio.GetBiografia(Candidato.Id);
            if (detalle != null)
            {
                Biografia = detalle.Descripcion;
                Url = detalle.Titulo;
            }
            Cargos = Repositorio.GetCargos(Candidato.Id);
            Estudios = Repositorio.GetEstudios(Candidato.Id);
        }

        private List<Detalle> estudios;

        public List<Detalle> Estudios
        {
            get { return estudios; }
            set
            {
                estudios = value;
                OnPropertyChanged("Estudios");
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

        private string idBannerCargos;

        public string IdBannerCargos
        {
            get { return idBannerCargos; }
            set
            {
                idBannerCargos = value;
                OnPropertyChanged("IdBannerCargos");
            }
        }

        private string idBannerEstudios;

        public string IdBannerEstudios
        {
            get { return idBannerEstudios; }
            set
            {
                idBannerEstudios = value;
                OnPropertyChanged("IdBannerEstudios");
            }
        }

        private List<Detalle> cargos;

        public List<Detalle> Cargos
        {
            get { return cargos; }
            set
            {
                cargos = value;
                OnPropertyChanged("Cargos");
            }
        }


        private string biografia;

        public string Biografia
        {
            get { return biografia; }
            set
            {
                biografia = value;
                OnPropertyChanged("Biografia");
            }
        }

        private string url;

        public string Url
        {
            get { return url; }
            set
            {
                url = value;
                OnPropertyChanged("Url");
            }
        }


    }
}
