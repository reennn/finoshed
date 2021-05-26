using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{
    public GameObject InHand;
    public GameObject TakenObj;
    public GameObject Trigger;
    public GameObject Text_E;

    private void OnTriggerStay(Collider other)
    {
        Text_E.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            InHand.SetActive(false);
            TakenObj.SetActive(true);
            Trigger.SetActive(false);
            Text_E.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Text_E.SetActive(false);
    }
}
