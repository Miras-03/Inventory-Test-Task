using Inventory.Model;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
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

        public Action<InventoryItem> OnItemLClick;
        public Action<InventoryItem> OnItemRClick;
        public Action<InventoryItem> OnItemDropped;

        private int id;

        private void OnEnable()
        {
            CharacteristicsFilter.OnFilter += Filter;
        }

        private void OnDestroy()
        {
            CharacteristicsFilter.OnFilter -= Filter;
        }

        public void SetItem(ItemSO itemData, int entitiesCount)
        {
            entity.sprite = itemData.entity;
            characteristics.sprite = itemData.characteristics;
            this.entitiesCount.text = $"x{entitiesCount}";
            characteristicsCount.text = $"+{itemData.characteristicsCount}";
            id = itemData.id;
        }

        public void PoinerClick(BaseEventData eventData)
        {
            PointerEventData pointerData = (PointerEventData)eventData;
            if (pointerData.button == PointerEventData.InputButton.Right)
                OnItemRClick?.Invoke(this);
            else
                OnItemLClick?.Invoke(this);
        }

        public void Drop() => OnItemDropped?.Invoke(this);

        private void Filter(int id)
        {
            bool doesMath = this.id == id || id == 0 ? true : false;
            gameObject.SetActive(doesMath);
        }
    }
}