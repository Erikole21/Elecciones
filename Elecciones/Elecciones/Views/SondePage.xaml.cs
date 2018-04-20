using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elecciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SondePage : ContentPage
    {
        public SondePage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.SondeViewModel();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            (this.BindingContext as ViewModels.SondeViewModel).Votar();            
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (this.BindingContext as ViewModels.SondeViewModel).CandidatoSeleccionado = e.SelectedItem as Modelos.Senso;
        }


    }
}