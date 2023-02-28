using System.Collections.Generic;
using Assets.Scripts.Inventory;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Inventory Container")]
public class InventoryContainer : ScriptableObject
{
    public List<InventorySlot> InventorySlots;

    public Item GetItem(int index)
    {
        return InventorySlots[index].Item;
    }
}   