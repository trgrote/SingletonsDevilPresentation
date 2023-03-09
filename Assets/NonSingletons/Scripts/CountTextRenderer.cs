using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(TMPro.TMP_Text))]
public class CountTextRenderer : MonoBehaviour
{
    TMPro.TMP_Text _text;
    [SerializeField] GameObjectRuntimeSet _set;

    void Awake()
    {
        _text = GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "" + _set.Set.Count();
    }
}
