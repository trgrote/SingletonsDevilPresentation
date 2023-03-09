using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDestroyer : MonoBehaviour
{
    [NaughtyAttributes.Button]
    public void DestroyAllFlowers()
    {
        FlowerManager.Instance.DestroyAllFlowers();
    }
}
