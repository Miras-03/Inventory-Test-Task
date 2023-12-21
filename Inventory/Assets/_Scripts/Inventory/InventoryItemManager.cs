using Inventory.Model;
using UnityEngine;

namespace Inventory
{
    public sealed class InventoryItemManager : MonoBehaviour
    {
        [SerializeField] private InventorySO inventory;
        [SerializeField] private RectTransform parent;

        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            for (int i = 0; i < inventory.entities.Count; i++)
            {
                int concreteItem = i;
                EntitySO itemData = inventory.entities[concreteItem];
                CharacteristicSO characteristic = itemData.characteristic;
                InventoryItem item = itemData.entity;
                Instantiate(item, item.transform.position, Quaternion.identity, parent);
                item.SetItem(itemData, characteristic, itemData.itemQuantity);
            }
        }
    }
}