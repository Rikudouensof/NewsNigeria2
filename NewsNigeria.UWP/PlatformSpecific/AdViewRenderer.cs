using Microsoft.Advertising.WinRT.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms;


[assembly: ExportRenderer(typeof(NewsNigeria.Control.AdControlView), typeof(NewsNigeria.UWP.PlatformSpecific.AdViewRenderer))]
namespace NewsNigeria.UWP.PlatformSpecific
{
    class AdViewRenderer : ViewRenderer<Control.AdControlView, AdControl>
    {
        string bannerId = "";
        AdControl adView;
        string applicationID = "";
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
                AdUnitId = bannerId,
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
                Height = height,
                Width = width
            };
         }

        protected override void OnElementChanged(ElementChangedEventArgs<Control.AdControlView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                CreateNativeAdControl();
                SetNativeControl(adView);
            }
        }
    }
}
