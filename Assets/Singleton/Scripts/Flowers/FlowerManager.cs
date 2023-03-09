using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FlowerManager
{
    #region Singleton Crap
    private static FlowerManager _singleton;

    public static FlowerManager Instance
    {
        get
        {
            if (_singleton == null)
            {
                _singleton = new FlowerManager();
            }

            return _singleton;
        }
    }
    #endregion

    private List<GameObject> _players = new List<GameObject>();

    public void AddFlower(GameObject go)
    {
        _players.Add(go);
    }

    public void RemoveFlower(GameObject go)
    {
        _players.Remove(go);
    }

    public GameObject GetMostRecentlyAddedFlower()
    {
        return _players.Last();
    }

    public int Count()
    {
        return _players.Count();
    }

    public void DestroyAllFlowers()
    {
        _players.ForEach(go => GameObject.Destroy(go, 0.1f));
    }
}
