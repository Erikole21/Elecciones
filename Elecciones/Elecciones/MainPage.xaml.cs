using Acr.UserDialogs;
using Elecciones.Modelos;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elecciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Appearing += MainPage_Appearing;
        }

        private void TapSondeo_Tapped(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                Navigation.PushAsync(new Views.SondePage());
            }
            else
                UserDialogs.Instance.Alert(new AlertConfig() { Message = "Esta opción necesita conexion a internet, Revise conexión e intente de nuevo", Title = "Elecciones" });

        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            lstCandidatos.SelectedItem = null;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Candidato _candidato = e.SelectedItem as Candidato;
                Candidato candidato = new Candidato()
                {
                    Id = _candidato.Id,
                    Edad = _candidato.Edad,
                    Foto = _candidato.Foto,
                    Nombre = _candidato.Nombre,
                    Origen = _candidato.Origen,
                    PartidoPolitico = _candidato.PartidoPolitico,
                    Slogan = _candidato.Slogan
                };
                //para evitar q se quede seleccionada un candidato
                Navigation.PushAsync(new Views.DetallesTabPage(candidato));
            }
        }
    }
}
