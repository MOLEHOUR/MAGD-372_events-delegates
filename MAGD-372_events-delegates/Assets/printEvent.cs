using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printEvent : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.Pressed += Print;
    }
    void OnDisable()
    {
        EventManager.Pressed -= Print;
    }
    void Print()
    {
        Debug.Log("the print event is working");
    }
}
