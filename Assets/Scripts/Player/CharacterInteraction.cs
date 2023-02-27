using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteraction : MonoBehaviour
{
    public void InteractWithWorld(InputAction.CallbackContext context)
    {
        if (context.action.triggered)
        {

            if (ItemPanelManager.Instance.IsShowing)
            {
                ItemPanelManager.Instance.HideItemPanel();
                return;
            }

            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            var interactable = Physics2D.OverlapPointAll(worldPoint)
                                     .Where(c => c.GetComponent<Interactable>() != null)
                                     .Select(c => c.GetComponent<Interactable>())
                                     .FirstOrDefault();

            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
