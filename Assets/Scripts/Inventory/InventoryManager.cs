
using System.Collections.Generic;
using Assets.Scripts.Inventory;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    
    [SerializeField] private InventoryContainer inventoryContainer;
    [SerializeField] private List<InventoryButton> inventoryButtons;

    private int selectedItemIndex;

    private void Awake()
    {
        Instance = this;

        InitButtons();
    }

    public void RefreshToolbar()
    {
        for (int i = 0; i < inventoryContainer.InventorySlots.Count; i++)
        {
            InventorySlot itemSlot = inventoryContainer.InventorySlots[i];
            InventoryButton button = inventoryButtons[i];

            if (itemSlot.HasItem)
            {
                button.SetData(itemSlot);
            }
            else
            {
                button.Clear();
            }
        }
    }

    public Item GetSelectedItem()
    {
        return inventoryContainer.GetItem(selectedItemIndex);
    }

    private void InitButtons()
    {
        for (int i = 0; i < inventoryButtons.Count; i++)
        {
            InventoryButton button = inventoryButtons[i];

            button.SetIndex(i);
            button.OnClick += HandleInventoryButtonClick;
        }

        RefreshToolbar();
    }

    private void HandleInventoryButtonClick(int buttonIndex)
    {
        selectedItemIndex = buttonIndex;

        for (int i = 0; i < inventoryButtons.Count; i++)
        {
            var button = inventoryButtons[i];
            
            button.Select(i == buttonIndex);
        }
    }
}