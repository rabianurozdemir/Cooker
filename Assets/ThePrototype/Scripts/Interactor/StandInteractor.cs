using System.Collections.Generic;
using ThePrototype;
using ThePrototype.Scripts.Interactor;
using UnityEngine;

public class StandInteractor : BaseInteractor
{
    public GameObject effect;
    List<GameObject> _children ;

    private void OnTriggerEnter2D(Collider2D col)
    {
       /* GameObject e = Instantiate(effect);
        e.transform.position = col.transform.position;
        DestroyFood(col.gameObject);
        Destroy(e, 0.8f);*/
       if (col.TryGetComponent<FoodType>(out var foodType))
       {
           _children = new List<GameObject>();
           var childrenSprite = foodType.transform.GetComponentsInChildren<SpriteRenderer>();
           
           childrenSprite[0].enabled=false;
           childrenSprite[1].enabled=true;
       }
       DestroyFood(col.gameObject);
    }
    
    public override void DestroyFood(GameObject obj)
    {
        base.DestroyFood(obj);
    }
}
