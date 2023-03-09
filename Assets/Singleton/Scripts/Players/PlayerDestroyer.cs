using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    [NaughtyAttributes.Button]
    public void DestroyAllPlayers()
    {
        PlayerManager.Instance.DestroyAllPlayers();
    }
}
