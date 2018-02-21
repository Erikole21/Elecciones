using Elecciones.UWP;
using Microsoft.Advertising.WinRT.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;
using Windows.UI.Xaml;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Elecciones.Controles.AdControlView), typeof(AdViewRender))]
namespace Elecciones.UWP
{
    public class AdViewRender : ViewRenderer<Controles.AdControlView, AdControl>
    {
        AdControl adView;
        string applicationID = "9pp3k9kghklz";
        void CreateNativeAdControl()
        {
            if (adView != null)
                return;

            var width = 300;
            var height = 50;
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop")
            {
                width = 728;
                height = 90;
            }

            // Setup your BannerView, review AdSizeCons class for more Ad sizes. 
            adView = new AdControl
            {
                ApplicationId = applicationID,
                AdUnitId = Element.AdUnitId,
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
                Height = height,
                Width = width
            };
        }
        
        protected override void OnElementChanged(ElementChangedEventArgs<Controles.AdControlView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null && Control == null)
            {                
                CreateNativeAdControl();
                SetNativeControl(adView);
            }
            
        }
    }
}
