using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Elecciones
{
    public partial class App : Application
    {
        public static string RutaBD;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Elecciones.MainPage());
        }

        public App(string rutaBd)
        {
            InitializeComponent();
            RutaBD = rutaBd;
            MainPage = new NavigationPage(new Elecciones.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
