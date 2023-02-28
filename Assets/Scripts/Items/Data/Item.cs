using UnityEngine;

[CreateAssetMenu(menuName = "Data/Item")]
public class Item : ScriptableObject
{
    public bool IsStackable;
    public Sprite Icon;
    public StructureAction StructureAction;
}