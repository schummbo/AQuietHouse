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

    public void ClearStructureTile(Vector3Int position)
    {
        structureMap.SetTile(position, null);
    }
}