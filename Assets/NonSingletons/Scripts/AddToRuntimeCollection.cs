using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToRuntimeCollection : MonoBehaviour
{
    [SerializeField] GameObjectRuntimeSet _set;

    // Start is called before the first frame update
    void OnEnable()
    {
        _set.Set.Add(gameObject);
    }

    // Update is called once per frame
    void OnDisable()
    {
        _set.Set.Remove(gameObject);
    }
}
