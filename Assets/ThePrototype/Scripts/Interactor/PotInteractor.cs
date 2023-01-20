using System.Collections.Generic;
using ThePrototype.Scripts.Recipe;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = System.Random;

namespace ThePrototype.Scripts.Interactor
{
    public class PotInteractor : BaseInteractor
    {
        public List<RecipeSettings> recipes;
        private int _score;
        public Text recipeContent;
        public List<FoodTypes> activeRecipe;

        
        void Start()
        {
            SelectRecipe();
        }
        
        public void SelectRecipe()
        {
            int randomRecipe = UnityEngine.Random.Range(0, recipes.Count);
            activeRecipe = Utilities.Utilities.CloneRecipeSetting( recipes[randomRecipe]);
            
            for(int i=0; i<activeRecipe.Count; i++)
            {
                recipeContent.text += (activeRecipe[i] + "\n");
                Debug.Log(activeRecipe[i] + "\n");
            }
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        { 
            bool _isContain = false;
            if (col.gameObject.TryGetComponent<FoodType>(out var foodTypes))
            {
                
                foreach (FoodTypes food in activeRecipe)
                {
                    if (food == foodTypes.Type)
                    {
                        _isContain = true;
                        int index = activeRecipe.FindIndex(a => a.Equals(food)); // Find index
                        activeRecipe.RemoveAt(index); // Remove item
                        break;
                    }
                }
                if (_isContain)
                {
                    _score++;
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
            DestroyFood(col.gameObject);
        }

        public override void DestroyFood(GameObject obj)
        {
            //play effect
            //do something
            base.DestroyFood(obj);
        }
        
    }
}