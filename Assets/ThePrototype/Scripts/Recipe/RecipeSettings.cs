using System.Collections.Generic;
using UnityEngine;


namespace ThePrototype.Scripts.Recipe       
{
    [CreateAssetMenu(menuName = "Cooker/Recipe/Recipe")]
    public class RecipeSettings : ScriptableObject
    {
        public List<FoodTypes> recipeList;
    }
}
