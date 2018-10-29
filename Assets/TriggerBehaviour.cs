using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public Behaviour effect;
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyUp(key))
        {
            effect.enabled = true;
        }
    }
}
