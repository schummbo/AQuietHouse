using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Data/Structure Panel")]
public class StructurePanelInfo : ScriptableObject
{
    public TileBase StructureTile;
    public StructurePanelType PanelType;
}
