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
	public partial class CocktailDetailPage : ContentPage
	{
        Recipes _cocktail;
		public CocktailDetailPage (Recipes cocktail)
		{
			InitializeComponent ();
            _cocktail = cocktail;
            this.BindingContext = _cocktail;
		}

        private void btn_Favorite_Clicked(object sender, EventArgs e)
        {
            _cocktail.Favorite = !_cocktail.Favorite;
            App._db.Recipes.Update(_cocktail);
            App._db.SaveChanges();
        }
    }
}