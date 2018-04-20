using Elecciones.Datos;
using Elecciones.Modelos;
using Plugin.DeviceInfo;
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

    }
}
