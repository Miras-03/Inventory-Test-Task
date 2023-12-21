using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public sealed class InventorySwitcher : MonoBehaviour
    {
        [SerializeField] private GameObject[] inventroyPanels;
        [SerializeField] private Button[] entityButtons;

        private void Start() => EnableInventory(inventroyPanels[0]);

        private void OnEnable() => AddButtonListeners();

        private void OnDisable() => RemoveButtonListeners();

        private void AddButtonListeners()
        {
            entityButtons[0].onClick.AddListener(() => EnableInventory(inventroyPanels[0]));
            entityButtons[1].onClick.AddListener(() => EnableInventory(inventroyPanels[1]));
            entityButtons[2].onClick.AddListener(() => EnableInventory(inventroyPanels[2]));
            entityButtons[3].onClick.AddListener(() => EnableInventory(inventroyPanels[3]));
        }

        private void RemoveButtonListeners()
        {
            foreach (var button in entityButtons) 
                button.onClick.RemoveAllListeners();
        }

        private void EnableInventory(GameObject inventory)
        {
            DisablePanels();
            inventory.SetActive(true);
        }

        private void DisablePanels()
        {
            foreach (GameObject panel in inventroyPanels) 
                panel.SetActive(false);
        }
    }
}