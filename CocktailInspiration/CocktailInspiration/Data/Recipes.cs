using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CocktailInspiration.Data
{
    public class Recipes : INotifyPropertyChanged 
    {

        private bool privFavorite;
        private double privRating;

        public int ID { get; set; }
        public string CocktailName { get; set; }
        public List<IngredientQuantity> NeededIngredients { get; set; }
        public string Picture { get; set; }
        public string Instructions { get; set; }
        public double Rating
        {
            get { return privRating; }
            set
            {
                privRating = value;
                OnPropertyChanged("Rating");
            }
        }
        public bool Favorite
        {
            get { return privFavorite; }
            set
            {
                privFavorite = value;
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
