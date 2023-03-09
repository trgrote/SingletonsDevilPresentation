using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFlowerToFlowerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        FlowerManager.Instance.AddFlower(this.gameObject);
    }

    // Update is called once per frame
    void OnDisable()
    {
        FlowerManager.Instance.RemoveFlower(this.gameObject);        
    }
}
