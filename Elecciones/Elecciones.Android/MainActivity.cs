﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Android.Gms.Ads;
using Acr.UserDialogs;

namespace Elecciones.Droid
{
    [Activity(Label = "Elecciones", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            UserDialogs.Init(this);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            MobileAds.Initialize(ApplicationContext, "ca-app-pub-2325431808910219~1757571865");

            Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity = this;

            LoadApplication(new App());            
        }
    }
}

