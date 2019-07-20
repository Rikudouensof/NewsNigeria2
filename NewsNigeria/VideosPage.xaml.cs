using NewsNigeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsNigeria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideosPage : ContentPage
    {
        
        public VideosPage(NewsSorce newsSorce)
        {
            InitializeComponent();
            BindingContext = newsSorce ?? throw new ArgumentNullException();
        }

        private void Thewebview_Navigating(object sender, WebNavigatingEventArgs e)
        {
            SiteNavActivityIndcator.IsVisible = true;
            Thewebview.IsVisible = false;
        }

        private void Thewebview_Navigated(object sender, WebNavigatedEventArgs e)
        {
            SiteNavActivityIndcator.IsVisible = false;
            Thewebview.IsVisible = true;
        }
    }
}