using UnityEngine;
using UnityEngine.Tilemaps;

public class StructureMapReader : MonoBehaviour
{
    [SerializeField] private Tilemap foundationMap;
    [SerializeField] private Tilemap structureMap;

    public static StructureMapReader Instance;

    private void Awake()
    {
        Instance = this;
    }

    public TileBase GetFoundationTile(Vector3Int position)
    {
        return foundationMap.GetTile(position);
    }

    public bool ClearStructureTile(Vector3Int position)
    {
        if (structureMap.GetTile(position))
        {
            structureMap.SetTile(position, null);
            return true;
        }

        return false;
    }

    public Vector3 TilemapToWorldPosition(Vector3Int tilemapPosition)
    {
        return foundationMap.CellToWorld(tilemapPosition);
    }
}