using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private string Name;
    [SerializeField] private string Description;

    public void Interact()
    {
        ItemPanelManager.Instance.ShowItemPanel(Description, this.gameObject.GetComponent<SpriteRenderer>().sprite);
    }
}
