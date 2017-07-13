using CocktailInspiration.Data;
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
            lview_Ingredients.ItemsSource = App._db.IngredientQuantity.Where(x => x.Cocktail == null).ToList();
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