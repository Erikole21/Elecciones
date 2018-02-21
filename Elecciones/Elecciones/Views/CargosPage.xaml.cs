﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elecciones.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CargosPage : ContentPage
    {
        public CargosPage()
        {
            InitializeComponent();
        }

        public CargosPage(ViewModels.DetalleViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}