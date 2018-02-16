using Elecciones.Datos;
using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        private Candidato candidatoSeleccionado;

        public Candidato CandidatoSeleccionado
        {
            get { return candidatoSeleccionado; }
            set
            {
                candidatoSeleccionado = value;
                OnPropertyChanged("CandidatoSeleccionado");
            }
        }


    }
}
