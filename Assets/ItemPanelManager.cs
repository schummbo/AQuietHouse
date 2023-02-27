using UnityEngine;
using UnityEngine.UI;

public class ItemPanelManager : MonoBehaviour
{
    public static ItemPanelManager Instance;

    [SerializeField] private GameObject ItemPanel;
    [SerializeField] private Text Description;
    [SerializeField] private Image Image;

    public bool IsShowing => this.ItemPanel.activeInHierarchy;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowItemPanel(string description, Sprite sprite)
    {
        Description.text = description;
        Image.sprite = sprite;

        ItemPanel.SetActive(true);
    }

    public void HideItemPanel()
    {
        ItemPanel.SetActive(false);
    }
}
