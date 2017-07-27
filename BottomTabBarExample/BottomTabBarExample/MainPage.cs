using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarExample
{
    public class MainPage : BottomBarPage
    {
        public MainPage()
        {

            Children.Add(new DenunciaPage());


            Children.Add(new NewsPage());


            Children.Add(new MapaPage());

         
            NavigationPage.SetHasNavigationBar(this, true);


            ToolbarItem tb1 = new ToolbarItem();
            tb1.Text = "Sair";
            tb1.Clicked += Tb_Clicked;
            tb1.Priority = 0;

            ToolbarItem tb2 = new ToolbarItem();
            tb2.Text = "Sair";
            tb2.Clicked += Tb_Clicked;
            tb1.Priority = 1;


            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
        }

        private async void Tb_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }
    }
}
