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
    public partial class RadioListPage : ContentPage
    {
        List<NewsSorce> newsSorces = new List<NewsSorce>
        {
             new NewsSorce{id = 1, Name = "Wazobia FM", ImageUrl="Radio.png", TheUrl="http://radio.wazobiafm.com/", About="Ogbonge Yarns Dey On Top Wazobia FM Now Now."},
             new NewsSorce{id = 2, Name = "Best Afro Fm", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/best-afro-fm.html", About="Best of African Music"},
             new NewsSorce{id = 3, Name = "Aminci Radio 103.9 FM", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/aminci-radio-1039-fm.html", About="Domin Cigaban Al'umma"},
             new NewsSorce{id = 4, Name = "Sekielo Afro Radio", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/sekielo-afro-radio.html", About=""},
             new NewsSorce{id = 5, Name = "Nigerian FM(USA)", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/nigerian-fm-usa.html", About=""},
             new NewsSorce{id = 6, Name = "Baze FM Nigeria & Ghana", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/baze-fm.html", About="Nigerian / Ghanaian Live Radio Online"},
             new NewsSorce{id = 7, Name = "Radio Biafra", ImageUrl="Radio.png", TheUrl="https://www.liveonlineradio.net/english/radio-biafra.htm", About=""},
             new NewsSorce{id = 8, Name = "Radio Palmwine Youruba", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/radio-palmwine-yoruba.html", About="Radio Palmwine Yoruba, Nigerian Radio"},
             new NewsSorce{id = 9, Name = "Royal FM", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/royal-fm-ilorin.html", About="Royal FM Ilorin"},
             new NewsSorce{id = 10, Name = "Fortis Radio 9", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/fortis-radio-9---nigerian-live-radio-online.html", About="Fortis Radio 9 - Nigerian Live Radio"},
             new NewsSorce{id = 11, Name = "Wisdom Gate Radio", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/wisdom-gate-radio.html", About="Wisdom Gate Radio, WIG - Nigerian Live Radio"},
             new NewsSorce{id = 12, Name = "Fish FM Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/fish-fm-nigeria.html", About="Fish FM, broadcasting from Lagos, Nigeria."},
             new NewsSorce{id = 13, Name = "Nigerian Gospel Radio", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/nigerian-gospel-radio.html", About="Nigerian Gospel Radio, based in London (UK) - Christian Live Broadcasts and empowering music."},
             new NewsSorce{id = 14, Name = "Sleek FM", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/sleek-fm-nigeria.html", About="Sleek FM - Nigerian Live Radio"},
             new NewsSorce{id = 15, Name = "Royal FM Ilorin", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/royal-fm-ilorin.html", About="Nigerian Live Radio Station Music and News!"},
             new NewsSorce{id = 16, Name = "Web Radio Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/web-radio-nigeria.html", About="News, World News, harts songs, Alternative music, soft rock, old skool, RnB, best of Reggae."},
             new NewsSorce{id = 17, Name = "Brook Radio Lagos", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/brook-radio-lagos.html", About="News, harts songs, Christian worship, Gospel."},
             new NewsSorce{id = 18, Name = "Sekielo Afro Radio", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/sekielo-afro-radio.html", About="African (Nigerian) station in Europe (Italiy),"},
             new NewsSorce{id = 19, Name = "Fortis Radio 1", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/fortis-radio-main-station---nigerian-live-radio.html", About="Fortis Radio 1 Nigeria (Main)"},
             new NewsSorce{id = 20, Name = "Dala FM Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/dala-fm-885.html", About=""},
             new NewsSorce{id = 21, Name = "Enterprise Radio Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/enterprise-radio-nigeria.html", About="Nigerian Business and Empowerment Radio. Not 24/7 online."},
             new NewsSorce{id = 22, Name = "Freedom FM Radio", ImageUrl="Radio.png", TheUrl="https://freedomradionig.com/default/", About="Freedom FM Radio Kano"},
             new NewsSorce{id = 23, Name = "Radio Palmwine Igbo", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/radio-palmwine-igbo.html", About=" Igbo Ogene, Highlife, Bongo, Igbo Gospel, Waka, Egwu Nkwa Ndi Igbo, Ekpuru Ngwa, Ese, Ese-Ikhe, Ukom and Ogbom."},
             new NewsSorce{id = 24, Name = "LoveWorld Internet Radio", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/loveworld-internet-radio.html", About="Christian Live Online Radio Station. Broadcasting from Lagos, good news and empowering christian music. "},
             new NewsSorce{id = 25, Name = "Radio Sapientia 95.3 FM Onitsha", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/radio-sapientia-953-fm.html", About=""},
             new NewsSorce{id = 26, Name = "Rock City FM Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/rockcity-1019-fm.html", About="Not 24/7 radio"},
             new NewsSorce{id = 26, Name = "Good News Radio Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/good-news-radio-nigeria.html", About=""},
             new NewsSorce{id = 26, Name = "Top Radio Nigeria 90.9", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/top-radio-909-fm.html", About="News and Music from Nigeria"},
             new NewsSorce{id = 26, Name = "Domi Media Radio Nigeria", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/domi-media-radio.html", About="Not 24/7 online."},
             new NewsSorce{id = 26, Name = "XM Radio 1", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/xm-radio1.html", About="XM Radio 1, Nigeria"},
             new NewsSorce{id = 26, Name = "Radio Continental 102.3FM", ImageUrl="Radio.png", TheUrl="http://nigeria.radio-live.co/radio-continental-1023fm.html", About=""},
             
             // new NewsSorce{id = 26, Name = "", ImageUrl="Radio.png", TheUrl="", About=""},

        };
        public RadioListPage()
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
            await Navigation.PushAsync(new RadioPage(newsSorces));
            ContactListView.SelectedItem = null;
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            var newsScores = ContactListView.SelectedItem as NewsSorce;
            Navigation.PushAsync(new RadioPage(newsScores));
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