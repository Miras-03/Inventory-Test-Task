using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public sealed class CloseButton : MonoBehaviour
    {
        [Space(10)]
        [SerializeField] private GameObject[] inventoryPanels;
        private Button button;

        private void Awake() => button = GetComponent<Button>();

        private void Start() => gameObject.SetActive(false);

        private void OnEnable()
        {
            button.onClick.AddListener(CloseInventories);
            button.onClick.AddListener(()=>gameObject.SetActive(false));
        }

        private void OnDestroy() => button.onClick.RemoveAllListeners();

        private void CloseInventories()
        {
            foreach (var panel in inventoryPanels)
                panel.SetActive(false);
        }
    }
}