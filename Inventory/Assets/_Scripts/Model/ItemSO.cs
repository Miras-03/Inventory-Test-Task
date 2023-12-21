using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "Item", menuName = "ScriptableObject/UI")]
    public sealed class ItemSO : ScriptableObject
    {
        public InventoryItem itemPrefab;
        public Sprite entity;
        public Sprite characteristics;

        public int id;
        public int itemQuantity;
        public int characteristicsAmount;
    }
}