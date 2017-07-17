using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CocktailInspiration.Data
{
    public class IngredientQuantity : INotifyPropertyChanged
    {
        private Ingredients privIngredient;
        private double privQuantity;

        public int IngredientQuantityID { get; set; }
        public Ingredients Ingredient
        {
            get { return privIngredient; }
            set
            {
                privIngredient = value;
                OnPropertyChanged("Ingredient");
            }
        }
        public double Quantity
        {
            get { return privQuantity; }
            set
            {
                privQuantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        public Recipes Cocktail { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public static void checkIngredientConsistency()
        {
            List<Ingredients> allIngredients = App._db.Ingredients.ToList();
            List<Ingredients> ingrWithOutCocktail = App._db.IngredientQuantity.Where(x => x.Cocktail == null).Select(x => x.Ingredient).ToList();

            foreach (Ingredients item in allIngredients.Except(ingrWithOutCocktail).ToList())
            {
                IngredientQuantity toAdd = new IngredientQuantity()
                {
                    Ingredient = item,
                    Quantity = 0
                };
                App._db.IngredientQuantity.Add(toAdd);
            }
            App._db.SaveChanges();
        }
    }

}
