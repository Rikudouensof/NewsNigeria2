using MyAccountBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsNigeria
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        List<Menulis> menulis = new List<Menulis>
        {
            new Menulis{id = 1, MenuName = "NewsPaper", About="Today's update newspaper", pictureURL="NewsPaper3.png"},
            new Menulis{id= 2, MenuName = "Videos", About="Live shows & news", pictureURL="TV1.png"},
            new Menulis{id= 3, MenuName="Gossip", About="Hottest stories when it is still fresh", pictureURL="Gossip2d.png"},
            new Menulis{id= 4, MenuName="Radio", About="Listen from anywhere in the world", pictureURL="dd.png"},

        };
        public MainPage()
        {
            InitializeComponent();
            MenuListview.ItemsSource = menulis.OrderBy(x => x.MenuName).ToList();
            MasterBehavior = MasterBehavior.Popover;
            Master.BackgroundColor = Color.Transparent;
            Detail = new HomePage();
        }

        private void MenuListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var zemenulis = e.SelectedItem as Menulis;

            if (zemenulis.MenuName == "Videos")
            {
                Detail = new VideoListPage();
            }
            else if (zemenulis.MenuName == "Gossip")
            {
                Detail = new GossipListPage();
            }
            else if (zemenulis.MenuName == "NewsPaper")
            {
                Detail = new NewsListPage();
            }
            else if (zemenulis.MenuName == "Radio")
            {
                Detail = new RadioListPage();
            }

            IsPresented = false;
        }
    }
}
