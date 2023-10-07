using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void GetInput();
    public static event GetInput Pressed;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Pressed?.Invoke();
        }
    }
     //if (Input.GetButtonDown("Jump"))
       // {
         //   Clicked?.Invoke();
        //}
}
