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
	public partial class IngridientsPage : ContentPage
	{
		public IngridientsPage ()
		{
			InitializeComponent ();
            List<IGrouping<IngredientTypes, IngredientQuantity>> groupedIngredients = App._db.IngredientQuantity.Where(x => x.Cocktail == null)
                .Include(x => x.Ingredient)
                .GroupBy(x => x.Ingredient.Type)
                .ToList();
            lview_Ingredients.ItemsSource = groupedIngredients;

        }

        private void btn_AddIngr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IngredientDetailPage());
        }

        private void lview_Ingredients_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new IngredientDetailPage((IngredientQuantity)e.Item));
            //Navigation.PushModalAsync(new IngredientDetailPage());
        }
    }
}