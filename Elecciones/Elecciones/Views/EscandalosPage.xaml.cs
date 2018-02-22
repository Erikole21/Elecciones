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
    public partial class EscandalosPage : ContentPage
    {
        public EscandalosPage()
        {
            InitializeComponent();
        }

        public EscandalosPage(Candidato candidato)
        {
            InitializeComponent();
            BindingContext = new ViewModels.EscandalosViewModel(candidato);

        }
    }
}