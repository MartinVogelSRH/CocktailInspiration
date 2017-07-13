using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailInspiration.Data
{
    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IngredientTypes Type { get; set; }
        public Units Unit { get; set; }
        //public IngredientQuantity AvailableQuantity { get; set; }
    }
    public enum IngredientTypes
    {
        Tool,
        Alcoholic,
        Fruit,
        Juice
    }
    public enum Units
    {
        Liter,
        Piece
    }
}
