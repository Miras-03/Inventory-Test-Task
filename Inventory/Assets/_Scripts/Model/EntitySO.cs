using UnityEngine;

namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "Item", menuName = "ScriptableObject/UI")]
    public sealed class EntitySO : ScriptableObject
    {
        public CharacteristicSO characteristic;
        public InventoryItem entity;
        public Sprite entityImage;
        [HideInInspector] public Sprite characteristics;

        [HideInInspector] public int id;
        [HideInInspector] public int itemQuantity;
        [HideInInspector] public int characteristicsAmount;
    }
}