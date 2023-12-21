using Inventory;
using Inventory.Model;
using UnityEngine;
using UnityEngine.UI;

public class Entity : MonoBehaviour
{
    [Space(10)]
    [Header("ScriptableObjects")]
    [SerializeField] private EntitySO itemData;
    [SerializeField] private InventorySO inventoryData;

    [Space(10)]
    [Header("InventoryScripts")]
    [SerializeField] private InventoryItemManager inventoryItemManager;

    [Header("UI")]
    [Space(20)]
    [SerializeField] private Button button;
    private Image itemImage;

    [Space(20)]
    [SerializeField] private int itemQuantity;


    private void Awake()
    {
        itemImage = GetComponent<Image>();
        itemImage.sprite = itemData.entityImage;
    }

    private void OnEnable()
    {
        button.onClick.AddListener(PickUpItem);
        button.onClick.AddListener(DestroyItem);
    }

    private void OnDestroy() => button.onClick.RemoveAllListeners();

    private void DestroyItem() => Destroy(itemImage);

    private void PickUpItem()
    {
        if (itemData != null)
            inventoryData.Add(itemData, itemQuantity);
        inventoryItemManager.Spawn();
    }
}