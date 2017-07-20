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
            contemporaryClassics();
        }
        public static void DropDB()
        {
            App._db.Database.EnsureDeleted();
            App._db = new DatabaseContext();
            App._db.Database.EnsureCreated();
        }
        public static void contemporaryClassics()
        {
            Ingredients coke = new Ingredients()
            {
                Name = "Cola",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Juice
            };
            Ingredients wodka = new Ingredients()
            {
                Name = "Wodka",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Alcoholic
            };
            Ingredients limes = new Ingredients()
            {
                Name = "Limes",
                Unit = Units.Piece,
                Type = IngredientTypes.Fruit
            };
            Ingredients prosecco = new Ingredients()
            {
                Name = "Prosecco",
                Type = IngredientTypes.Alcoholic,
                Unit = Units.Centiliter
            };
            Ingredients peachPuree = new Ingredients()
            {
                Name = "Peach Puree",
                Type = IngredientTypes.Juice,
                Unit = Units.Centiliter
            };
            Ingredients coffeeLiqueur = new Ingredients()
            {
                Name = "Coffee liqueur",
                Type = IngredientTypes.Juice,
                Unit = Units.Centiliter
            };
            Ingredients tomatoJuice = new Ingredients()
            {
                Name = "Tomato Juice",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Juice
            };
            Ingredients lemonJuice = new Ingredients()
            {
                Name = "Lemon Juice",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Juice
            };
            Ingredients worcestershireSouce = new Ingredients()
            {
                Name = "Worcestershire Sauce",
                Unit = Units.Mililiter,
                Type = IngredientTypes.Juice
            };
            Ingredients tabasco = new Ingredients()
            {
                Name = "Tabasco",
                Unit = Units.Mililiter,
                Type = IngredientTypes.Juice
            };
            Ingredients celerySalt = new Ingredients()
            {
                Name = "Celery salt",
                Unit = Units.Gram,
                Type = IngredientTypes.Juice
            };
            Ingredients pepper = new Ingredients()
            {
                Name = "Pepper",
                Unit = Units.Gram,
                Type = IngredientTypes.Fruit
            };
            Ingredients cachaca = new Ingredients()
            {
                Name = "Cachaça",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Alcoholic
            };
            Ingredients sugar = new Ingredients()
            {
                Name = "Sugar",
                Unit = Units.Gram,
                Type = IngredientTypes.Fruit
            };
            Ingredients champagne = new Ingredients()
            {
                Name = "Champagne",
                Type = IngredientTypes.Alcoholic,
                Unit = Units.Centiliter
            };
            Ingredients cognac = new Ingredients()
            {
                Name = "Cognac",
                Type = IngredientTypes.Alcoholic,
                Unit = Units.Centiliter
            };
            Ingredients angosturaBitters = new Ingredients()
            {
                Name = "Angostura Bitters",
                Type = IngredientTypes.Alcoholic,
                Unit = Units.Centiliter
            };
            Ingredients cointreau = new Ingredients()
            {
                Name = "Cointreau",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Alcoholic
            };
            Ingredients cranberryJuice = new Ingredients()
            {
                Name = "Cranberry Juice",
                Type = IngredientTypes.Juice,
                Unit = Units.Centiliter
            };
            Ingredients whiteRum = new Ingredients()
            {
                Name = "White Rum",
                Unit = Units.Centiliter,
                Type = IngredientTypes.Alcoholic
            };





            IngredientQuantity availableCoke = new IngredientQuantity()
            {
                Ingredient = coke,
                Quantity = 350
            };
            IngredientQuantity availableWodka = new IngredientQuantity()
            {
                Ingredient = wodka,
                Quantity = 450
            };

            Recipes wodkaCoke = new Recipes()
            {
                CocktailName = "Wodka-Cola",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        Quantity = 20
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = coke,
                        Quantity = 30
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
                        Ingredient = prosecco,
                        Quantity = 10
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = peachPuree,
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
                        Quantity = 5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = coffeeLiqueur,
                        Quantity = 2
                    }
                },
                Rating = 4,
                Picture = "ContemporaryClassics_black_russian.png",
                Instructions = "Pour the ingredients into the old fashioned-glass filled with ice cubes. Stir gently.\r\n\r\nNote: for White Russian, float fresh cream on the top and stir gently."
            };
            Recipes bloodyMary = new Recipes()
            {
                CocktailName = "Bloody Mary",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        Quantity = 4.5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = tomatoJuice,
                        Quantity = 9
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = lemonJuice,
                        Quantity = 1.5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = worcestershireSouce,
                        Quantity = 2
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = tabasco,
                        Quantity = 1
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = celerySalt,
                        Quantity = 1
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = pepper,
                        Quantity = 1
                    }
                },
                Instructions = "Stir gently, pour all ingredients into highball glass.\r\nGarnish with celery and lemon wedge (optional).",
                Picture = "ContemporaryClassics_bloody_mary.jpg",
                Rating = 4
            };
            Recipes caipirinha = new Recipes()
            {
                CocktailName = "Caipirinha",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = cachaca,
                        Quantity = 5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = sugar,
                        Quantity = 3
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = limes,
                        Quantity = 0.5
                    }
                },
                Instructions = "Place lime and sugar in an old fashioned glass and muddle.\r\nFill glass with ice and Cachaça. (For a Caipiroska – use Vodka instead of Cachaça).",
                Picture = "ContemporaryClassics_caipirinha.jpg",
                Rating = 5
            };
            Recipes champagneCocktail = new Recipes()
            {
                CocktailName = "Champagne Cocktail",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = champagne,
                        Quantity = 9
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = cognac,
                        Quantity = 1
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = angosturaBitters,
                        Quantity = 1
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = sugar,
                        Quantity = 2
                    }
                },
                Instructions = "Add dash of Angostura bitter onto sugar cube and drop it into champagne flute.\r\nAdd cognac followed by pouring gently chilled champagne.\r\nGarnish with orange slice and maraschino cherry.",
                Rating = 1,
                Picture = "ContemporaryClassics_champagne_cocktail.jpg"
            };
            Recipes cosmopolitan = new Recipes()
            {
                CocktailName = "Cosmopolitan",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = wodka,
                        Quantity = 4
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = cointreau,
                        Quantity = 1.5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = cranberryJuice,
                        Quantity = 3
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = limes,
                        Quantity = 1
                    }
                },
                Rating = 3,
                Instructions = "Make lime juice out of the lime.\r\nShake all ingredients in cocktail shaker filled with ice.\r\nStrain into a large cocktail glass .Garnish with lime slice.",
                Picture = "ContemporaryClassics_cosmopolitan.jpg"
            };
            Recipes cubaLibre = new Recipes()
            {
                CocktailName = "Cuba Libre",
                NeededIngredients = new List<IngredientQuantity>()
                {
                    new IngredientQuantity()
                    {
                        Ingredient = whiteRum,
                        Quantity = 5
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = coke,
                        Quantity = 12
                    },
                    new IngredientQuantity()
                    {
                        Ingredient = limes,
                        Quantity = 0.5
                    }
                },
                Instructions = "Build all ingredients in a highball glass filled with ice.\r\nGarnish with lime wedge.",
                Rating = 5,
                Picture = "ContemporaryClassics_cuba_libre.jpg"
            };

            App._db.Ingredients.Add(coke);
            App._db.Ingredients.Add(wodka);
            App._db.Ingredients.Add(limes);
            App._db.IngredientQuantity.Add(availableCoke);
            App._db.IngredientQuantity.Add(availableWodka);
            App._db.Recipes.Add(wodkaCoke);
            App._db.Recipes.Add(bellini);
            App._db.Recipes.Add(blackRussian);
            App._db.Recipes.Add(bloodyMary);
            App._db.Recipes.Add(caipirinha);
            App._db.Recipes.Add(champagneCocktail);
            App._db.Recipes.Add(cosmopolitan);
            App._db.Recipes.Add(cubaLibre);
            App._db.SaveChanges();
        }
    }
}
