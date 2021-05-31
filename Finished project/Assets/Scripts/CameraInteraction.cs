using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    [SerializeField] float Distance;

    RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(transform.position, transform.forward, out hit, Distance);
            if (hit.transform && hit.transform.GetComponent<Button>())
            {
                hit.transform.GetComponent<Button>().UseButton();
            }
            if (hit.transform && hit.transform.GetComponent<Screw>())
            {
                hit.transform.GetComponent<Screw>().UseBolt();
            }
        }
    }
}
