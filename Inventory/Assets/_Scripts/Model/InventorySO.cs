using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Inventory")]
    public sealed class InventorySO : ScriptableObject
    {
        public List<ItemSO> items;

        public bool isEmpty => items == null;

        public void Add(ItemSO item, int quantity)
        {
            for (int i = 0; i < quantity; i++)
                items.Add(item);
            item.itemQuantity += quantity;
        }

        public void Remove(ItemSO item) => items.Remove(item);

        public void Clear() => items.Clear();
    }
}