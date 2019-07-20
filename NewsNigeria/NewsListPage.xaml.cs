using NewsNigeria.Control;
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
    public partial class NewsListPage : ContentPage
    {

        List<NewsSorce> newsSorces = new List<NewsSorce>
        {
             new NewsSorce{id = 1, Name = "Vanguard", ImageUrl="Newspaper2.png", TheUrl="https://www.vanguardngr.com/", About=""},
             new NewsSorce{id = 1, Name = "Punch Newspaper", ImageUrl="Newspaper2.png", TheUrl="https://punchng.com/", About=""},
             new NewsSorce{id = 1, Name = "This Day news", ImageUrl="Newspaper2.png", TheUrl="http://www.thisdaylive.com/", About=""},
             new NewsSorce{id = 1, Name = "The Nation", ImageUrl="Newspaper2.png", TheUrl="https://thenationonlineng.net/", About=""},
             new NewsSorce{id = 1, Name = "Nigerian Tribune", ImageUrl="Newspaper2.png", TheUrl="https://tribuneonlineng.com/", About=""},
             new NewsSorce{id = 1, Name = "The guardian", ImageUrl="Newspaper2.png", TheUrl="https://guardian.ng/", About=""},
             new NewsSorce{id = 1, Name = "Sahara reporters", ImageUrl="Newspaper2.png", TheUrl="http://saharareporters.com/", About=""},
             new NewsSorce{id = 1, Name = "Leadership Newspaper Nigeria", ImageUrl="Newspaper2.png", TheUrl="http://leadership.ng/", About=""},
             new NewsSorce{id = 1, Name = "The SUn", ImageUrl="Newspaper2.png", TheUrl="https://www.sunnewsonline.com/", About="daily sun"},
             new NewsSorce{id = 1, Name = "PM News Nigeria", ImageUrl="Newspaper2.png", TheUrl="https://www.pmnewsnigeria.com/", About=""},
             new NewsSorce{id = 1, Name = "Daily Trust", ImageUrl="Newspaper2.png", TheUrl="https://www.dailytrust.com.ng/", About=""},
             new NewsSorce{id = 1, Name = "Premium Times Nigeria", ImageUrl="Newspaper2.png", TheUrl="https://www.premiumtimesng.com/", About=""},
             new NewsSorce{id = 1, Name = "Independent", ImageUrl="Newspaper2.png", TheUrl="https://www.independent.ng/", About=""},
             new NewsSorce{id = 1, Name = "Osun Defender", ImageUrl="Newspaper2.png", TheUrl="http://www.osundefender.com/", About=""},
             new NewsSorce{id = 1, Name = "Imo Trumpeta", ImageUrl="Newspaper2.png", TheUrl="http://www.imotrumpeta.com/", About=""},
             new NewsSorce{id = 1, Name = "Business News", ImageUrl="Newspaper2.png", TheUrl="http://businessnews.com.ng/", About=""},

             /*
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},
             new NewsSorce{id = 1, Name = "", ImageUrl="News2.png", TheUrl="", About=""},

             */
        };
        public NewsListPage()
        {
            InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
               AdUnitId = AppConstants.BannerId
            };
            ContactListView.ItemsSource = newsSorces.OrderBy(p => p.Name).ToList();
        }

        async private void ContactListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var newsSorces = e.SelectedItem as NewsSorce;
            await Navigation.PushAsync(new Page1(newsSorces));
            ContactListView.SelectedItem = null;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var newsScores = ContactListView.SelectedItem as NewsSorce;
            Navigation.PushAsync(new Page1(newsScores));
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