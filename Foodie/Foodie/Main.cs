using System;
using System.Diagnostics;
using Xamarin.Forms;
namespace Foodie
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new EditRecipePage());
        }
    }

}
