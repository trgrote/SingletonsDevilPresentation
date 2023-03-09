using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject _playerPrefab;
    public Transform _firstSpawnPosition;

    [NaughtyAttributes.Button]
    public void Spawn()
    {
        // Grab the lateset player and spawn a new player to the left of them
        var position = _firstSpawnPosition.position;

        if (PlayerManager.Instance.Count() > 0)
        {
            position = PlayerManager.Instance.GetMostRecentlyAddedPlayer().transform.position;
        }

        position += new Vector3(1, -0.25f, 0);

        Instantiate(_playerPrefab, position, Quaternion.identity);
    }
}
