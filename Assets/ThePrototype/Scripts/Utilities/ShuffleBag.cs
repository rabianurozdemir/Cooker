using System;
using UnityEngine;


namespace ThePrototype.Scripts.Utilities
{
    public class ShuffleBag<T>
    {
        private System.Random _random = new();

        private T[] _items;
        private int currentIndex;

        public ShuffleBag()
        {
            _items = new T[0];
        }

        public void Add(T item, int weight = 1)
        {
            T[] newItems = new T[_items.Length + weight];
            _items.CopyTo(newItems, 0);
            for (int i = _items.Length; i < newItems.Length; i++)
            {
                newItems[i] = item;
            }

            _items = newItems;
        }

        public T Next()
        {
            if (_items.Length == 0) throw new InvalidOperationException("The bag is empty.");

            currentIndex = _random.Next(0, _items.Length);
            return _items[currentIndex];
        }
    }
}