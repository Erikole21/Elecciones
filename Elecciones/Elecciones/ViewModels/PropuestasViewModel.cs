using Elecciones.Datos;
using Elecciones.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
