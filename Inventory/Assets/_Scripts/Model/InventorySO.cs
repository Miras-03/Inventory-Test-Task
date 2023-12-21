using System.Collections.Generic;
using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Inventory")]
    public sealed class InventorySO : ScriptableObject
    {
        public List<EntitySO> entities;

        public bool isEmpty => entities == null;

        public void Add(EntitySO item, int quantity)
        {
            for (int i = 0; i < quantity; i++)
                entities.Add(item);
            item.itemQuantity += quantity;
        }

        public void Remove(EntitySO item) => entities.Remove(item);

        public void Clear() => entities.Clear();
    }
}