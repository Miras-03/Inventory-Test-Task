using UnityEngine;

[CreateAssetMenu(fileName = "Characteristic", menuName = "ScriptableObject/Characteristic")]
public class CharacteristicSO : ScriptableObject
{
    public Sprite characteristic;
    public int amount;
}