using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] GameObjectRuntimeSet _set;

    [NaughtyAttributes.Button]
    public void DestroyAllFlowers()
    {
        _set.Set.ForEach(go => GameObject.Destroy(go, 0.1f));
    }
}
