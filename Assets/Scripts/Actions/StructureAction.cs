using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Data/Structure Action")]
public class StructureAction : ScriptableObject
{
    public Item PanelToPlace;
    public List<TileBase> ApplicableTiles;

    public void Apply(Vector3Int position)
    {
        var foundationTile = StructureMapReader.Instance.GetFoundationTile(position);

        if (ApplicableTiles.Contains(foundationTile))
        {
            if (PanelToPlace == null)
            {
                StructureMapReader.Instance.ClearStructureTile(position);
            }
        }
    }
}
