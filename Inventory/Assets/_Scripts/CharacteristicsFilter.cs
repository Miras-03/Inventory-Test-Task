using Inventory;
using Inventory.Model;
using System;
using UnityEngine;
using UnityEngine.UI;

public sealed class CharacteristicsFilter : MonoBehaviour
{
    [SerializeField] private CharacteristicSO characteristic;
    [SerializeField] private InventorySO inventory;

    private void Awake() => GetComponent<Button>().onClick.AddListener(Filter);

    private void OnDestroy() => GetComponent<Button>().onClick.RemoveListener(Filter);

    private void Filter()
    {
        inventory.entities[0].entity.gameObject.SetActive(false);
    }
}