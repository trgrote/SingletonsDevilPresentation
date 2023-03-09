using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="GameObject Runtime Set")]
public class GameObjectRuntimeSet : ScriptableObject
{
    [HideInInspector]
    public List<GameObject> Set;
}
