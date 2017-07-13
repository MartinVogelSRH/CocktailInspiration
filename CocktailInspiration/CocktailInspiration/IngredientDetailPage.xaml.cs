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
            //this.BindingContext = new Ingredients() { Name = "Test name" };
            this.BindingContext = new IngredientQuantity()
            {
                Ingredient = new Ingredients() { Name = "TestName", Type = IngredientTypes.Alcoholic },
                AvailableQuantity = 5
            };
            pck_Ingredients.ItemsSource = App._db.Ingredients.ToList();


        }
    }
}