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
    public partial class VideoListPage : ContentPage
    {
        List<NewsSorce> newsSorces = new List<NewsSorce>
        {
             new NewsSorce{id = 1, Name = "NTA", ImageUrl="TV2.png", TheUrl="https://www.nta.ng/live", About="NTA Int"},
             new NewsSorce{id = 1, Name = "Channels TV", ImageUrl="TV2.png", TheUrl="https://www.channelstv.com/live/", About=""},
             new NewsSorce{id = 1, Name = "TVC NEWS", ImageUrl="TV2.png", TheUrl="https://www.youtube.com/watch?v=pi89dv8hYy4", About=""},
             new NewsSorce{id= 4, Name="AIT TV ", ImageUrl="TV2.png", TheUrl="http://www.aitonline.tv/live", About="Africa Independent Television"},
             new NewsSorce{id = 5, Name="Galaxy Television Nigeria",ImageUrl="TV2.png", TheUrl="https://www.galaxytvonline.com/video?live=livestream", About=""},
             new NewsSorce{id = 5, Name="Wazobia TV",ImageUrl="TV2.png", TheUrl="http://wazobiatv.tv/live/", About=""},
             new NewsSorce{id = 5, Name="Silverbird TV",ImageUrl="TV2.png", TheUrl="http://silverbirdtv.com/live/", About=""},
             new NewsSorce{id = 5, Name="Africa Magic",ImageUrl="TV2.png", TheUrl="https://www.youtube.com/watch?v=LwXPyrfDHIc", About=""},
             new NewsSorce{id = 5, Name="Sound city",ImageUrl="TV2.png", TheUrl="https://www.youtube.com/watch?v=85wRB3L_X4w", About=""},
             new NewsSorce{id =5, Name="Biafra TV", ImageUrl="TV2.png", TheUrl="http://www.biafratv.co/", About=""},



        };
        public VideoListPage()
        {
            
            InitializeComponent();
            ContactListView.ItemsSource = newsSorces.OrderBy(p => p.Name).ToList();
        }

        async private void ContactListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var newsSorces = e.SelectedItem as NewsSorce;
            await Navigation.PushAsync(new VideosPage(newsSorces));
            ContactListView.SelectedItem = null;
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            var newsScores = ContactListView.SelectedItem as NewsSorce;
            Navigation.PushAsync(new VideosPage(newsScores));
        }

        private void ContactfilterSearchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ContactListView.BeginRefresh();

            if (ContactfilterSearchbar.Text == null || string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                ContactListView.ItemsSource = ContactListView.ItemsSource;
            }
            else
            {
                ContactListView.ItemsSource = newsSorces.Where(i => i.Name.Contains(e.NewTextValue));


            }
        }
    }
}