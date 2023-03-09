using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TMPro.TMP_Text))]
public class PlayerCountRenderer : MonoBehaviour
{
    TMPro.TMP_Text _text;

    void Awake()
    {
        _text = GetComponent<TMPro.TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "" + PlayerManager.Instance.Count();
    }
}
