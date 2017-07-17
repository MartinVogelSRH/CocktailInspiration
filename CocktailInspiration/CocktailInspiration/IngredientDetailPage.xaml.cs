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
	public partial class IngredientDetailPage : ContentPage
	{
        public IngredientDetailPage(IngredientQuantity currentIngredient)
        {
            InitializeComponent();
            //this.BindingContext = currentIngredient;
            pck_Ingredients.ItemsSource = App._db.IngredientQuantity.ToList();
            pck_Ingredients.SelectedItem = currentIngredient;
            pck_Ingredients.IsEnabled = false;
            

        }
        public IngredientDetailPage()
        {
            InitializeComponent();
            
            pck_Ingredients.ItemsSource = App._db.IngredientQuantity
                .Where(x => x.Cocktail == null && x.Quantity == 0)
                .ToList();
            pck_Ingredients.IsEnabled = true;
            //Binding bindIngredient = new Binding("Ingredient");
            //pck_Ingredients.SetBinding(Picker.SelectedItemProperty, bindIngredient);

        }

        private void btn_Save_Clicked(object sender, EventArgs e)
        {
            IngredientQuantity currentIngredient = (IngredientQuantity)pck_Ingredients.SelectedItem;
            if (currentIngredient.IngredientQuantityID == 0)
            {
                App._db.IngredientQuantity.Add(currentIngredient);
            }
            else
            {
                App._db.IngredientQuantity.Update(currentIngredient);
            }
            App._db.SaveChanges();
            Navigation.PopModalAsync();
        }
    }
}