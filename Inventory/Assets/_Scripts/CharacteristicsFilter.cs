using Inventory.Model;
using System;
using UnityEngine;
using UnityEngine.UI;

public sealed class CharacteristicsFilter : MonoBehaviour
{
    [SerializeField] private InventorySO inventory;
    [SerializeField] private int id;

    private void Awake() => GetComponent<Button>().onClick.AddListener(Filter);

    private void OnDestroy() => GetComponent<Button>().onClick.RemoveListener(Filter);

    private void Filter()
    {
        Debug.Log(id);
    }
}