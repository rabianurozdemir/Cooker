using System.Collections;
using ThePrototype.Scripts.Utilities;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject[] foods;
    public float xBound, yBound;

    private ShuffleBag<GameObject> _shuffleBag = new ShuffleBag<GameObject>();
    void Start()
    {
        StartCoroutine((SpawnRandomGameObject()));
        foreach (var food in foods)
        {
            _shuffleBag.Add(food);
        }
    }

    void Shuffle()
    {
        int lastIndex = foods.Length - 1;
        while (lastIndex > 0)
        {
            GameObject tempValue = foods[lastIndex];
            int randomIndex = new System.Random().Next(0, lastIndex);
            foods[lastIndex] = foods[randomIndex];
            foods[randomIndex] = tempValue;
            lastIndex--;
        }
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        int randomFood = Random.Range(0, foods.Length);
        //Shuffle();
        Instantiate(_shuffleBag.Next(), new Vector2(Random.Range(-xBound, xBound), yBound), Quaternion.identity);
        StartCoroutine((SpawnRandomGameObject()));
    }
}