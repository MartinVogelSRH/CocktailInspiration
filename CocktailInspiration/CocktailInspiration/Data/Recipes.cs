using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CocktailInspiration.Data
{
    public class Recipes : INotifyPropertyChanged 
    {
        public int ID { get; set; }
        public string CocktailName { get; set; }
        public List<IngredientQuantity> NeededIngredients { get; set; }
        public string Instructions { get; set; }
        public double Rating { get; set; }
        private bool fav;
        public bool Favorite
        {
            get { return fav; }
            set
            {
                fav = value;
                OnPropertyChanged("Favorite");
            }
        }

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
