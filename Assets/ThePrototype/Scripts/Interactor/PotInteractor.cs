using System;
using System.Collections.Generic;
using ThePrototype.Scripts.Recipe;
using UnityEngine;

namespace ThePrototype.Scripts.Interactor
{
    public class PotInteractor : BaseInteractor
    {
        public List<RecipeSettings> recipes;

        private void Awake()
        {
            
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent<FoodTypes>(out var foodTypes))
            {
                
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