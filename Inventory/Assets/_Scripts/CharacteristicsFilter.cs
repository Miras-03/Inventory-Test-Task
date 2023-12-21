using System;
using UnityEngine;
using UnityEngine.UI;

public sealed class CharacteristicsFilter : MonoBehaviour
{
    public static Action<int> OnFilter;
    [SerializeField] private int id;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Filter);
    }

    private void OnDestroy() => button.onClick.RemoveAllListeners();

    private void Filter()
    {
        Debug.Log(id);
        OnFilter?.Invoke(id);
    }
}