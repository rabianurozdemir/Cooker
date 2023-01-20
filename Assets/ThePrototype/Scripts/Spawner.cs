using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] foods;
    public float xBound, yBound;
    void Start()
    {
        StartCoroutine((SpawnRandomGameObject()));
    }
    
    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        int randomFood = Random.Range(0, foods.Length);
        
        Instantiate(foods[randomFood], new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        StartCoroutine((SpawnRandomGameObject()));
    }
}
