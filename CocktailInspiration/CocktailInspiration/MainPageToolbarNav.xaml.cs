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
	public partial class MainPageToolbarNav : ContentPage
	{
		public MainPageToolbarNav ()
		{
			InitializeComponent ();
            
            this.Content = (new CocktailInspirationPage()).Content;
        }

        private void tbi_Inspiration_Clicked(object sender, EventArgs e)
        {
            this.Content = (new CocktailInspirationPage()).Content;
        }

        private void tbi_Ingredient_Clicked(object sender, EventArgs e)
        {
            this.Content = (new IngridientsPage()).Content;
        }

        private void tbi_Favorites_Clicked(object sender, EventArgs e)
        {
            this.Content = (new FavoritesPage()).Content;
        }

    }
}