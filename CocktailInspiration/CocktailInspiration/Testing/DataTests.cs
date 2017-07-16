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
                Quantity = 3.5
            };
            IngredientQuantity availableWodka = new IngredientQuantity()
            {
                Ingredient = wodka,
                Quantity = 4.5
            };

            Recipes wodkaCoke = new Recipes()
            {
                CocktailName = "Wodka-Cola",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        Quantity = 0.2
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = coke,
                        Quantity = 0.3
                    }
                },
                Instructions = "1. Put Wodka in the glass.\r\n2. Put coke in the glass.\r\n3. Stir it around",
                Rating = 3.5,
                Picture = "Cocktail_Icon.png"
            };
            Recipes bellini = new Recipes()
            {
                CocktailName = "Bellini",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = new Ingredients()
                        {
                            Name = "Prosecco",
                            Type = IngredientTypes.Alcoholic,
                            Unit = Units.Centiliter
                        },
                        Quantity = 10
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = new Ingredients()
                        {
                            Name = "Peach Puree",
                            Type = IngredientTypes.Juice,
                            Unit = Units.Centiliter
                        },
                        Quantity = 5
                    }
                },
                Rating = 4,
                Picture = "ContemporaryClassics_bellini.jpg",
                Instructions = "Pour peach puree into chilled glass and add sparkling wine. Stir gently.\r\n\r\nVariations:\r\nPuccini(fresh mandarin juice)\r\nRossini(fresh strawberry puree)\r\nTintoretto(fresh pomegranate juice)"
            };
            Recipes blackRussian = new Recipes()
            {
                CocktailName = "Black Russian",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        Quantity = 0.05
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = new Ingredients()
                        {
                            Name = "Coffee liqueur",
                            Type = IngredientTypes.Juice,
                            Unit = Units.Centiliter
                        },
                        Quantity = 2
                    }
                },
                Rating = 4,
                Picture = "ContemporaryClassics_black_russian.png",
                Instructions = "Pour the ingredients into the old fashioned-glass filled with ice cubes. Stir gently.\r\n\r\nNote: for White Russian, float fresh cream on the top and stir gently."
            };

            App._db.Ingredients.Add(coke);
            App._db.Ingredients.Add(wodka);
            App._db.Ingredients.Add(limes);
            App._db.IngredientQuantity.Add(availableCoke);
            App._db.IngredientQuantity.Add(availableWodka);
            App._db.Recipes.Add(wodkaCoke);
            App._db.Recipes.Add(bellini);
            App._db.Recipes.Add(blackRussian);
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
