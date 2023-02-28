using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class CharacterItemManager : MonoBehaviour
{
    [SerializeField] private Tilemap structureTilemap;
    [SerializeField] private StructureContainer structureContainer;
    [SerializeField] private StructurePanelInfo NewWoodFloor;

    public void OnUseItem(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var cell = structureTilemap.WorldToCell(worldPoint);

            // get the selected item
            Item item = InventoryManager.Instance.GetSelectedItem();

            // see if it can apply to the structure
            if (item != null && item.StructureAction != null)
            {
                item.StructureAction.Apply(cell);
            }
        }
    }
}
