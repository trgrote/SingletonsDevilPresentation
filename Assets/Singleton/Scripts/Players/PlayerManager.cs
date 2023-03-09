using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerManager
{
    #region Singleton Crap
    private static PlayerManager _singleton;

    public static PlayerManager Instance
    {
        get
        {
            if (_singleton == null)
            {
                _singleton = new PlayerManager();
            }

            return _singleton;
        }
    }
    #endregion

    private List<GameObject> _players = new List<GameObject>();

    public void AddPlayer(GameObject go)
    {
        _players.Add(go);
    }

    public void RemovePlayer(GameObject go)
    {
        _players.Remove(go);
    }

    public GameObject GetMostRecentlyAddedPlayer()
    {
        return _players.Last();
    }

    public int Count()
    {
        return _players.Count();
    }

    public void DestroyAllPlayers()
    {
        _players.ForEach(go => GameObject.Destroy(go, 0.1f));
    }
}
