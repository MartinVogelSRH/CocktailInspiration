using CocktailInspiration.Data;
using CocktailInspiration.AI;
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
            base.OnAppearing();
            lview_Cocktails.ItemsSource = App._db.Recipes
                .Include(x => x.NeededIngredients)
                .ThenInclude(x => x.Ingredient)
                .ToList();
        }

        private void lview_Cocktails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage( new CocktailDetailPage((Recipes)e.Item)));

        }

        private void sw_Possible_Toggled(object sender, ToggledEventArgs e)
        {
            if (sw_Possible.IsToggled != true)
            {
                lview_Cocktails.ItemsSource = CocktailAI.possibleCocktails();
            }
            else
            {
                lview_Cocktails.ItemsSource = App._db.Recipes
                .Include(x => x.NeededIngredients)
                .ThenInclude(x => x.Ingredient)
                .ToList();
            }
        }




        //private async void btn_LoadToolbarNav_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new MainPageToolbarNav()));
        //}
    }
}