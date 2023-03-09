using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    public GameObject _flowerPrefab;
    public Transform _firstSpawnPosition;

    [NaughtyAttributes.Button]
    public void Spawn()
    {
        // Grab the lateset player and spawn a new player to the left of them
        var position = _firstSpawnPosition.position;

        if (FlowerManager.Instance.Count() > 0)
        {
            position = FlowerManager.Instance.GetMostRecentlyAddedFlower().transform.position;
        }

        position += new Vector3(1, -0.25f, 0);

        Instantiate(_flowerPrefab, position, Quaternion.identity);
    }
}
