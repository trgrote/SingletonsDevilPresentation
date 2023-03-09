using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _prefab;
    public Transform _firstSpawnPosition;
    [SerializeField] GameObjectRuntimeSet _set;

    [NaughtyAttributes.Button]
    public void Spawn()
    {
        // Grab the lateset player and spawn a new player to the left of them
        var position = _firstSpawnPosition.position;

        if (_set.Set.Count() > 0)
        {
            position = _set.Set.Last().transform.position;
        }

        position += new Vector3(1, -0.25f, 0);

        Instantiate(_prefab, position, Quaternion.identity);
    }
}
