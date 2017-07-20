using CocktailInspiration.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailInspiration.AI
{
    class CocktailAI
    {
        public static List<Recipes> possibleCocktails()
        {
            IngredientQuantity.checkIngredientConsistency();
            //Make sure all data is in the DB object (needed for Entity Framwork):
            List<Recipes> temp = App._db.Recipes
            .Include(x => x.NeededIngredients)
            .ThenInclude(x => x.Ingredient)
            .ToList();


            bool checkAnotherRound = true;
            List<Recipes> returnList = new List<Recipes>();
            //First, We will get our initial fact-base (a list of our available ingredients)
            List<IngredientQuantity> facts = App._db.IngredientQuantity
                .Include(x => x.Ingredient)
                .Where(x => x.Cocktail == null && x.Quantity != 0)
                .ToList();
            List<Ingredients> ingredientFacts =  facts.Select(x => x.Ingredient).ToList();
            //Next, we need to get a list of rules that require one or more of these Ingredients
            var recipesToCheck = App._db.IngredientQuantity
                .Join(ingredientFacts,
                ingrQ => ingrQ.Ingredient,
                fact => fact,
                (ingrQ, fact) => ingrQ)
                .Where(x => x.Cocktail != null)
                .Select(x=>x.Cocktail)
                .ToList();
            //Let´s loop through these rules and check those which 
            while (checkAnotherRound)
            {
                checkAnotherRound = false;
                recipesToCheck = recipesToCheck.Except(returnList).ToList();
                foreach (Recipes currentRecipetoCheck in recipesToCheck)
                {
                    int fulfilledRequirements = 0;
                    foreach (IngredientQuantity ingredientToCheck in currentRecipetoCheck.NeededIngredients)
                    {
                        if(facts.Where(x => x.Ingredient == ingredientToCheck.Ingredient && x.Quantity >= ingredientToCheck.Quantity).Count() != 0)
                        {
                            fulfilledRequirements++;
                        }
                    }
                    if (fulfilledRequirements == currentRecipetoCheck.NeededIngredients.Count())
                    {
                        returnList.Add(currentRecipetoCheck);
                        checkAnotherRound = true;
                    }
                }
            }
            return returnList;
        }
    }
}
