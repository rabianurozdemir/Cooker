using System;
using UnityEngine;


namespace ThePrototype
{
    [Serializable]
    public enum FoodTypes
    {
        Egg,
        GreenPepper,
        RedPepper,
        Lemon,
        Oil,
        Onion,
        Potato,
        Salt,
        Tomato,
        Yoghurt
        
    }
    public class FoodType : MonoBehaviour
    {
        [field: SerializeField] public FoodTypes Type { get; set; }
    }
}
