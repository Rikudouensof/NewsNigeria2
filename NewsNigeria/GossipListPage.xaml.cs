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
    public partial class GossipListPage : ContentPage
    {

        List<NewsSorce> newsSorces = new List<NewsSorce>
        {
             new NewsSorce{id = 1, Name = "The Geekkeep", ImageUrl="Gossip2.png", TheUrl="http://Geekkeep.blogspot.com", About=""},
             new NewsSorce{id = 1, Name = "Naij", ImageUrl="Gossip2.png", TheUrl="http://www.africapunch.com/", About=""},
             new NewsSorce{id = 1, Name = "National Accord", ImageUrl="Gossip2.png", TheUrl="https://nationalaccordnewspaper.com/", About=""},
             new NewsSorce{id = 1, Name = "Linda Ikeji", ImageUrl="Gossip2.png", TheUrl="https://www.lindaikejisblog.com/", About=""},
             new NewsSorce{id = 1, Name = "Cyber Naira", ImageUrl="Gossip2.png", TheUrl="https://cybernaira.com", About=""},
             new NewsSorce{id = 1, Name = "Bella Naija", ImageUrl="Gossip2.png", TheUrl="https://www.bellanaija.com", About=""},
             new NewsSorce{id = 1, Name = "Pulse", ImageUrl="Gossip2.png", TheUrl="https://www.pulse.ng", About=""},
             new NewsSorce{id = 1, Name = "Information Nigeria", ImageUrl="Gossip2.png", TheUrl="https://www.informationng.com", About=""},
             new NewsSorce{id = 1, Name = "Naijaloaded", ImageUrl="Gossip2.png", TheUrl="https://www.naijaloaded.com.ng", About=""},
             new NewsSorce{id = 1, Name = "Ladun Liadi ", ImageUrl="Gossip2.png", TheUrl="https://www.ladunliadinews.com/", About="Nigeria"},
             new NewsSorce{id = 1, Name = "The Net", ImageUrl="Gossip2.png", TheUrl="http://thenet.ng/", About="News and gossip"},
             new NewsSorce{id = 1, Name = "hotnigerianjobs", ImageUrl="Gossip2.png", TheUrl="https://www.hotnigerianjobs.com/", About="Job and work"},
             new NewsSorce{id = 1, Name = "360nobs", ImageUrl="Gossip2.png", TheUrl="http://360nobs.com/", About="Gist as they come"},
             new NewsSorce{id = 1, Name = "Lailas Blog", ImageUrl="Gossip2.png", TheUrl="https://lailasnews.com/", About=""},
             new NewsSorce{id = 1, Name = "Ynaija", ImageUrl="Gossip2.png", TheUrl="https://ynaija.com", About="Celebreties and info"},
             new NewsSorce{id = 1, Name = "Stella Dimokokorkus", ImageUrl="Gossip2.png", TheUrl="https://www.stelladimokokorkus.com", About="Celebreties and hot gossip"},
             new NewsSorce{id = 1, Name = "Stargist", ImageUrl="Gossip2.png", TheUrl="https://stargist.com", About="Celebrities, Entertainment, Hot gossip"},
             new NewsSorce{id = 1, Name = "Naijagists", ImageUrl="Gossip2.png", TheUrl="https://naijagists.com", About=""},



        };
        public GossipListPage()
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
            await Navigation.PushAsync(new GossipPage(newsSorces));
            ContactListView.SelectedItem = null;
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            var newsScores = ContactListView.SelectedItem as NewsSorce;
            Navigation.PushAsync(new GossipPage(newsScores));
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