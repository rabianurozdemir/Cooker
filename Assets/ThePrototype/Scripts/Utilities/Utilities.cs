using System.Collections.Generic;
using ThePrototype.Scripts.Recipe;
using Unity.VisualScripting;
using UnityEngine;
namespace ThePrototype.Scripts.Utilities
{
    public static class Utilities 
    {
        public static List<FoodTypes> CloneRecipeSetting(RecipeSettings recipeSettings)
        {
            List<FoodTypes> result = new List<FoodTypes>();
            for (int i = 0,limit=recipeSettings.recipeList.Count; i < limit; i++)
            {
                result.Add(recipeSettings.recipeList[i]);
            }

            return result;
        }
    }
}
