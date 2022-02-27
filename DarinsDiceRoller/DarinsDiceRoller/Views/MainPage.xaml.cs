using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DarinsDiceRoller.Models;

namespace DarinsDiceRoller.Views
{
    public partial class MainPage : FlyoutPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Dice, (NavigationPage)Detail);
            //MenuPages.Add((int)MenuItemType.About, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Dice:
                        MenuPages.Add(id, new NavigationPage(new DiceRollerPage()));
                        break;
                    case (int)MenuItemType.Main:
                        MenuPages.Add(id, new NavigationPage(new LandingPage()));
                        break;
                    case (int)MenuItemType.CharacterAdd:
                        MenuPages.Add(id, new NavigationPage(new CharacterAddPage()));
                        break;
                    case (int)MenuItemType.Credits:
                        MenuPages.Add(id, new NavigationPage(new CreditPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                        default:
                        break;
                    
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}
