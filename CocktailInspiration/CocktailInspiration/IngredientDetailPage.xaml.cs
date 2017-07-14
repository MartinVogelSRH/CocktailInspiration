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
            this.BindingContext = currentIngredient;
            pck_Ingredients.ItemsSource = App._db.Ingredients.ToList();
            pck_Ingredients.SelectedItem = currentIngredient.Ingredient;
            pck_Ingredients.IsEnabled = false;
            

        }
        public IngredientDetailPage()
        {
            InitializeComponent();
            
            this.BindingContext = new IngredientQuantity()
            {
            };
            pck_Ingredients.ItemsSource = App._db.Ingredients.ToList();
            pck_Ingredients.IsEnabled = true;
            Binding bindIngredient = new Binding("Ingredient");
            pck_Ingredients.SetBinding(Picker.SelectedItemProperty, bindIngredient);

        }

        private void btn_Save_Clicked(object sender, EventArgs e)
        {

        }
    }
}