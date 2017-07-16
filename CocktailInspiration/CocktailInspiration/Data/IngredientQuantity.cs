using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public double AvailableQuantity
        {
            get { return privQuantity; }
            set
            {
                privQuantity = value;
                OnPropertyChanged("AvailableQuantity");
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
    }
}
