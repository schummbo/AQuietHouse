using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour
{
    [SerializeField] private string Name;
    [SerializeField] private string Description;
    [SerializeField] private bool NeedsPopup;

    public void Interact()
    {
        var spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

        Sprite sprite = null;

        if (spriteRenderer != null)
        {
            sprite = spriteRenderer.sprite;
        }

        ItemPanelManager.Instance.ShowItemPanel(Description, sprite, NeedsPopup);
    }
}
