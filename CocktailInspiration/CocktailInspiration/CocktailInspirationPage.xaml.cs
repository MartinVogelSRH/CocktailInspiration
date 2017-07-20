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
            getCocktailsToShow();
            
        }

        private void getCocktailsToShow()
        {
            if (sw_Possible.IsToggled != true)
            {
                lview_Cocktails.ItemsSource = CocktailAI.possibleCocktails().OrderBy(x=>x.CocktailName).OrderByDescending(x=>x.Rating).ToList();
            }
            else
            {
                lview_Cocktails.ItemsSource = App._db.Recipes
                .Include(x => x.NeededIngredients)
                .ThenInclude(x => x.Ingredient)
                .OrderBy(x => x.CocktailName)
                .OrderByDescending(x => x.Rating)
                .ToList();
            }
            if (((List<Recipes>)lview_Cocktails.ItemsSource).Count == 0)
            {
                lbl_NoIngredients.IsVisible = true;
            }
            else
            {
                lbl_NoIngredients.IsVisible = false;
            }
        }

        private void lview_Cocktails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage( new CocktailDetailPage((Recipes)e.Item)));

        }

        private void sw_Possible_Toggled(object sender, ToggledEventArgs e)
        {
            getCocktailsToShow();
        }




        //private async void btn_LoadToolbarNav_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new MainPageToolbarNav()));
        //}
    }
}