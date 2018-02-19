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
            BindingContext = new ViewModels.DetalleViewModel(candidato);
        }

        private void propuestas_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PropuestasPage((this.BindingContext as ViewModels.DetalleViewModel).Candidato));
        }
    }
}