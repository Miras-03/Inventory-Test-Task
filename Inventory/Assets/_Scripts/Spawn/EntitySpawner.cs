using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    [SerializeField] private GameObject items;
    [SerializeField] private RectTransform parent;

    [SerializeField] private int itemSize;

    private void Start() => Spawn();

    public void Spawn()
    {
        for (int i = 0; i < itemSize-1; i++)
            Instantiate(items, items.transform.position, Quaternion.identity, parent);
    }
}