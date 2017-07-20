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
	public partial class FavoritesPage : ContentPage
	{
		public FavoritesPage()
		{
			InitializeComponent ();

		}

        private void lview_Cocktails_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new CocktailDetailPage((Recipes)e.Item)));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lview_Cocktails.ItemsSource = App._db.Recipes
                .Where(x => x.Favorite == true)
                .Include(x => x.NeededIngredients)
                .ThenInclude(x => x.Ingredient)
                .ToList();
            if (((List<Recipes>)lview_Cocktails.ItemsSource).Count == 0)
            {
                lbl_NoContent.IsVisible = true;
            }
            else
            {
                lbl_NoContent.IsVisible = false;
            }

        }
    }
}