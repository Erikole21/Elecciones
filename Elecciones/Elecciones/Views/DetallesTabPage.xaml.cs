using Elecciones.Modelos;
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
    public partial class DetallesTabPage : TabbedPage
    {
        public DetallesTabPage()
        {
            InitializeComponent();
        }

        public DetallesTabPage(Candidato candidato)
        {
            InitializeComponent();
            ViewModels.DetalleViewModel viewModel = new ViewModels.DetalleViewModel(candidato);
            BindingContext = viewModel;
            BiografiaPage biografia = new BiografiaPage(viewModel);
            this.Children.Add(biografia);
            CargosPage cargos = new CargosPage(viewModel);
            this.Children.Add(cargos);
            EstudiosPage estudios = new EstudiosPage(viewModel);
            this.Children.Add(estudios);
        }

        private void Propuestas_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropuestasPage((this.BindingContext as ViewModels.DetalleViewModel).Candidato));
        }

        private void Escandalos_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EscandalosPage((this.BindingContext as ViewModels.DetalleViewModel).Candidato));
        }       
    }
}