using System;

namespace Assets.Scripts.Inventory
{
    [Serializable]
    public class InventorySlot
    {
        public Item Item;
        public int Count;

        public bool HasItem => Item != null;
    }
}
