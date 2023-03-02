using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Data/Structure Action")]
public class StructureAction : ScriptableObject
{
    public Item PanelToPlace;
    public List<TileBase> ApplicableTiles;
    public GameObject ApplicationParticlesPrefab;

    public void Apply(Vector3Int position)
    {
        var foundationTile = StructureMapReader.Instance.GetFoundationTile(position);

        if (ApplicableTiles.Contains(foundationTile))
        {
            if (PanelToPlace == null)
            {
                if (!StructureMapReader.Instance.ClearStructureTile(position))
                {
                    return;
                }
            }

            if (ApplicationParticlesPrefab == null)
            {
                return;
            }

            var poof = Instantiate(
                ApplicationParticlesPrefab,
                StructureMapReader.Instance.TilemapToWorldPosition(position),
                Quaternion.identity);

            if (poof == null)
            {
                return;
            }

            var particles = poof.GetComponent<ParticleSystem>();

            if (particles != null)
            {
                particles.Play();
            }
        }
    }
}
