using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailInspiration.Data
{
    public class IngredientQuantity
    {
        public int IngredientQuantityID { get; set; }
        public Ingredients Ingredient { get; set; }
        public double AvailableQuantity { get; set; }
        public Recipes Cocktail { get; set; }
    }
}
