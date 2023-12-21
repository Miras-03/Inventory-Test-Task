using Inventory.Model;
using UnityEngine;

namespace Inventory
{
    public sealed class InventoryItemManager : MonoBehaviour
    {
        [SerializeField] private InventorySO inventory;
        [SerializeField] private RectTransform parent;
        private InventoryItemHandler inventoryItemHandler;

        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            for (int i = 0; i < inventory.items.Count; i++)
            {
                int concreteItem = i;
                ItemSO itemData = inventory.items[concreteItem];
                InventoryItem item = itemData.itemPrefab;
                Instantiate(item, item.transform.position, Quaternion.identity, parent);
                item.SetItem(itemData, itemData.itemQuantity);
                inventoryItemHandler = new InventoryItemHandler(item);
                inventoryItemHandler.SubscribeItemEvents();
            }
        }
    }
}