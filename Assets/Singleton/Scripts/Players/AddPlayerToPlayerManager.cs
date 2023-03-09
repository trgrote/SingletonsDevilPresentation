using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerToPlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        PlayerManager.Instance.AddPlayer(this.gameObject);
    }

    // Update is called once per frame
    void OnDisable()
    {
        PlayerManager.Instance.RemovePlayer(this.gameObject);        
    }
}
