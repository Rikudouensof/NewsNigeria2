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
    public partial class RadioPage : ContentPage
    {
       

        public RadioPage(NewsSorce newsSorce)
        {
            BindingContext = newsSorce ?? throw new ArgumentNullException();
            InitializeComponent();
        }

        private void Thewebview_Navigated(object sender, WebNavigatedEventArgs e)
        {
            SiteNavActivityIndcator.IsVisible = false;
            Thewebview.IsVisible = true;
            ControlButton.IsVisible = true;
            
        }

        private void Thewebview_Navigating(object sender, WebNavigatingEventArgs e)
        {
            SiteNavActivityIndcator.IsVisible = true;
            Thewebview.IsVisible = false;
            DisplayStacklayout.IsVisible = false;

        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            ControlButton.IsVisible = false;
            DisplayStacklayout.IsVisible = true;
            Thewebview.IsVisible = false;
        }
    }
}