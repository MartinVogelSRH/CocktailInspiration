using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CocktailInspiration.Data
{
    public class Ingredients : INotifyPropertyChanged
    {
        private IngredientTypes privType;
        private Units privUnit;

        public int ID { get; set; }
        public string Name { get; set; }
        public IngredientTypes Type
        {
            get { return privType; }
            set
            {
                privType = value;
                OnPropertyChanged("Type");
            }
        }
        public Units Unit
        {
            get { return privUnit; }
            set
            {
                privUnit = value;
                OnPropertyChanged("Unit");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //public IngredientQuantity AvailableQuantity { get; set; }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
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
        Centiliter,
        Mililiter,
        Liter,
        Piece
    }
}
