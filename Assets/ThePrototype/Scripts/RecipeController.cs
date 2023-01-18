using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RecipeController : MonoBehaviour
{
    private List<List<string>> recipes;
    public Text scoreText;
    private int _score;
    public Text recipeContent;
    public Text recipeName;
    public static List<string> activeRecipe;
    
    List<string> menemen = new List<string>()
    {
        "Tomato",
        "Tomato",
        "GreenPepper",
        "GreenPepper",
        "Egg",
        "Salt",
        "Oil"
    };

    List<string> friedPatatoes = new List<string>()
    {
        "Potato",
        "Potato",
        "Potato",
        "Oil",
        "Salt"
    };

    List<string> tomatoSoap = new List<string>()
    {
        "Tomato",
        "Tomato",
        "Tomato",
        "Oil",
        "Salt"
    };

    List<string> friedEgg = new List<string>()
    {
        "Egg",
        "Egg",
        "Oil",
        "Salt"
    };

    List<string> salad = new List<string>()
    {
        "Tomato",
        "GreenPepper",
        "RedPepper",
        "Oil",
        "Salt"
    };
    void Start()
    {
        recipes = new List<List<string>>() { menemen, friedPatatoes, tomatoSoap, friedEgg, salad };
        SelectRecipe();
    }
    
    public void SelectRecipe()
    {
        int randomRecipe = Random.Range(0, 5); 
        activeRecipe = recipes[randomRecipe];
        recipeName.text = activeRecipe.ToString();

        for(int i=0; i<activeRecipe.Count; i++)
        {
            recipeContent.text += (activeRecipe[i] + "\n");
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        //Destroy(other.gameObject);
        bool _isContain = false;

        if (gameObject.CompareTag("Pot"))
        {
            foreach (string food in activeRecipe)
            {
                if (food == other.tag)
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
    }
}
