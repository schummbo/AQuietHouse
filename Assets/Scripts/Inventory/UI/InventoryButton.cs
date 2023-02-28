using System;
using Assets.Scripts.Inventory;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image icon;
    [SerializeField] Text amount;
    [SerializeField] Image selectedImage;

    private int index;

    public Action<int> OnClick;

    public void Select(bool isSelected)
    {
        selectedImage.gameObject.SetActive(isSelected);
    }

    public void SetIndex(int i)
    {
        this.index = i;
    }

    public void SetData(InventorySlot itemSlot)
    {
        icon.gameObject.SetActive(true);
        icon.sprite = itemSlot.Item.Icon;

        if (itemSlot.Item.IsStackable)
        {
            amount.gameObject.SetActive(true);
            amount.text = itemSlot.Count.ToString();
        }
        else
        {
            amount.gameObject.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        this.OnClick?.Invoke(this.index);
    }

    public void Clear()
    {
        icon.sprite = null;
        icon.gameObject.SetActive(false);
        amount.gameObject.SetActive(false);
    }
}
