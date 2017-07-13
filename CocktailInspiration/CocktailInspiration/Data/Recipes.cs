using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailInspiration.Data
{
    public class Recipes
    {
        public int ID { get; set; }
        public string CocktailName { get; set; }
        public List<IngredientQuantity> NeededIngredients { get; set; }
        public string Instructions { get; set; }
        public double Rating { get; set; }

    }
}
