using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanelManager : MonoBehaviour
{
    public static ItemPanelManager Instance;

    [SerializeField] private GameObject ItemPanel;
    [SerializeField] private Text Description;
    [SerializeField] private Image Image;
    [SerializeField] private Text NonPopupDescription;

    public bool IsShowing => this.ItemPanel.activeInHierarchy;

    private void Awake()
    {
        Instance = this;
    }

    private Coroutine hideNonPopupDescriptionCoroutine;

    public void ShowItemPanel(string description, Sprite sprite, bool needsPopup)
    {
        if (needsPopup)
        {
            Description.text = description;
            Image.sprite = sprite;

            ItemPanel.SetActive(true);
        }
        else
        {
            if (hideNonPopupDescriptionCoroutine != null)
            {
                StopCoroutine(hideNonPopupDescriptionCoroutine);
            }

            NonPopupDescription.text = description;
            NonPopupDescription.gameObject.SetActive(true);

            hideNonPopupDescriptionCoroutine = StartCoroutine(HideNonPopupDescription());
        }
    }

    private IEnumerator HideNonPopupDescription()
    {
        yield return new WaitForSeconds(2);

        NonPopupDescription.gameObject.SetActive(false);
    }


    public void HideItemPanel()
    {
        ItemPanel.SetActive(false);
    }
}
