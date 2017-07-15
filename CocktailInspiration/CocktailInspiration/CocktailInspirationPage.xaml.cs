using CocktailInspiration.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CocktailInspiration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CocktailInspirationPage : ContentPage
	{
		public CocktailInspirationPage()
		{
			InitializeComponent();
            
        }

        private async void btn_LoadMasterDetail_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPageMasterDetail());
        }

        private async void btn_LoadTabbedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        protected override void OnAppearing()
        {

            lview_Cocktails.ItemsSource = App._db.Recipes
                .Include(x => x.NeededIngredients)
                .ThenInclude(x => x.Ingredient)
                .ToList();
            base.OnAppearing();
            
        }

        private void lview_Cocktails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage( new CocktailDetailPage((Recipes)e.Item)));

        }



        //private async void btn_LoadToolbarNav_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new MainPageToolbarNav()));
        //}
    }
}