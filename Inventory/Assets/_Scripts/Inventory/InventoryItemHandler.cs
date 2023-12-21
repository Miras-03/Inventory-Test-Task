using System;
using UnityEngine;

namespace Inventory
{
    public sealed class InventoryItemHandler : IDisposable
    {
        private InventoryItem inventoryItem;

        public InventoryItemHandler(InventoryItem inventoryItem) => this.inventoryItem = inventoryItem;

        public void Dispose() => UnsubscribeItemEvents();

        public void SubscribeItemEvents()
        {
            inventoryItem.OnItemRClick += HandleRClick;
            inventoryItem.OnItemLClick += HandleLClick;
            inventoryItem.OnItemDropped += HandleDrop;
        }

        public void UnsubscribeItemEvents()
        {
            inventoryItem.OnItemRClick -= HandleRClick;
            inventoryItem.OnItemLClick -= HandleLClick;
            inventoryItem.OnItemDropped -= HandleDrop;
        }

        private void HandleRClick(InventoryItem item)
        {
            Debug.Log("Right mouse clicked");
        }

        private void HandleLClick(InventoryItem item)
        {
            Debug.Log("Left mouse clicked");
        }

        private void HandleDrop(InventoryItem item)
        {
            Debug.Log("Drop");
        }
    }
}