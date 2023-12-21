using Inventory.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public sealed class InventoryItem : MonoBehaviour
    {
        [Space(10)]
        [Header("Images")]
        [SerializeField] private Image entity;
        [SerializeField] private Image characteristics;

        [Space(20)]
        [Header("Texts")]
        [SerializeField] private TextMeshProUGUI entitiesCount;
        [SerializeField] private TextMeshProUGUI characteristicsCount;

        public void SetItem(EntitySO itemData, CharacteristicSO characteristic, int entitiesCount)
        {
            entity.sprite = itemData.entityImage;
            characteristics.sprite = characteristic.characteristic;
            this.entitiesCount.text = $"x{entitiesCount}";
            characteristicsCount.text = $"+{characteristic.amount}";
        }
    }
}