using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEvent : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.Pressed += Teleport;
    }
    void OnDisable()
    {
        EventManager.Pressed -= Teleport;
    }
    void Teleport()
    {
        Vector2 pos = transform.position;
        pos.x = Random.Range(-7.0f, 7.0f);
        transform.position = pos;
    }
}
