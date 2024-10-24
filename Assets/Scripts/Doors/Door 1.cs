using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door1"))
        {
            UnityEngine.Debug.Log("DOOR1");
        }

        if (other.CompareTag("Door2"))
        {
            UnityEngine.Debug.Log("DOOR2");
        }

        if (other.CompareTag("Door3"))
        {
            UnityEngine.Debug.Log("DOOR3");
        }
    }
}
