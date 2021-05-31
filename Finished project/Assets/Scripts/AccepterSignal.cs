using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccepterSignal : MonoBehaviour
{
    [SerializeField] Button ButtonSignal;

    void Update()
    {
        if (ButtonSignal.Signal)
        {
            transform.rotation = Quaternion.Euler(50, -30, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(10, -30, 0);
        }
    }
}
