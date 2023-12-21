using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Inventory")]
    public sealed class InventorySO : ScriptableObject
    {
        public List<Item> items;

        public void Add(Item item) => items.Add(item);

        public void Remove(Item item) => items.Remove(item);
    }

    [Serializable]
    public struct Item
    {
        public ItemSO itemData;
        public int quantity;
        public bool isEmpty => itemData == null;
    }
}