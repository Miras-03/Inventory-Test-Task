using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public sealed class InventorySwitcher : MonoBehaviour
    {
        [Space(10)]
        [SerializeField] private CloseButton closeButton;

        [Space(20)]
        [Header("UI")]
        [SerializeField] private GameObject[] inventroyPanels;

        [Space(20)]
        [SerializeField] private Button[] entityButtons;

        private void OnEnable() => AddListeners();

        private void OnDisable() => RemoveListeners();

        private void AddListeners()
        {
            for (int i = 0; i < entityButtons.Length; i++)
            {
                int concreteItem = i;
                entityButtons[concreteItem].onClick.AddListener(DisableInventories);
                entityButtons[concreteItem].onClick.AddListener(() => inventroyPanels[concreteItem].SetActive(true));
                entityButtons[concreteItem].onClick.AddListener(() => closeButton?.gameObject.SetActive(true));
            }
        }

        private void RemoveListeners()
        {
            foreach (var b in entityButtons)
                b.onClick.RemoveAllListeners();
        }

        private void DisableInventories()
        {
            foreach (var p in inventroyPanels)
                p.SetActive(false);
        }
    }
}