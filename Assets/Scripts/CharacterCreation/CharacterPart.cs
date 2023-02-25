using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Character Creation/Character Part")]
public class CharacterPart : ScriptableObject
{
    public List<Sprite> WalkSouth;
    public List<Sprite> WalkNorth;
    public List<Sprite> WalkEast;
    public List<Sprite> WalkWest;
}
