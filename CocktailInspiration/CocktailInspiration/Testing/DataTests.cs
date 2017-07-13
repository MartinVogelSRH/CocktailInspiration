using CocktailInspiration.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailInspiration.Testing
{
    class DataTests
    {
        public static void GenerateData()
        {
            Ingredients coke = new Ingredients()
            {
                Name = "Cola",
                Unit = Units.Liter,
                Type = IngredientTypes.Juice
            };
            Ingredients wodka = new Ingredients()
            {
                Name = "Wodka",
                Unit = Units.Liter,
                Type = IngredientTypes.Alcoholic
            };
            Ingredients limes = new Ingredients()
            {
                Name = "Limes",
                Unit = Units.Piece,
                Type = IngredientTypes.Fruit
            };
            IngredientQuantity availableCoke = new IngredientQuantity()
            {
                Ingredient = coke,
                AvailableQuantity = 3.5
            };
            IngredientQuantity availableWodka = new IngredientQuantity()
            {
                Ingredient = wodka,
                AvailableQuantity = 4.5
            };

            Recipes wodkaCoke = new Recipes()
            {
                CocktailName = "Wodka-Cola",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        AvailableQuantity = 0.2
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = coke,
                        AvailableQuantity = 0.3
                    }
                },
                Instructions = "Put Wodka in the glass, then put coke in the glass. Stir it around",
                Rating = 3.5
            };
            
            App._db.Ingredients.Add(coke);
            App._db.Ingredients.Add(wodka);
            App._db.Ingredients.Add(limes);
            App._db.IngredientQuantity.Add(availableCoke);
            App._db.IngredientQuantity.Add(availableWodka);
            App._db.Recipes.Add(wodkaCoke);
            App._db.SaveChanges();
        }
        public static void DropDB()
        {
            App._db.Database.EnsureDeleted();
            App._db = new DatabaseContext();
            App._db.Database.EnsureCreated();
        }
    }
}
