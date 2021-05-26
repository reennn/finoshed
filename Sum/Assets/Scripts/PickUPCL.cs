using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPCL : MonoBehaviour
{
    public GameObject FuelTool_InHand;
    public GameObject FuelTool_TakenObj;
    public GameObject DirtTool_InHand;
    public GameObject DirtTool_TakenObj;
    public GameObject Trigger;
    public GameObject Text;
    private void OnTriggerStay(Collider other)
    {
        Text.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            FuelTool_InHand.SetActive(false);
            FuelTool_TakenObj.SetActive(true);
            Trigger.SetActive(false);
            Text.SetActive(false);

            if(DirtTool_TakenObj == true)
            {
                DirtTool_TakenObj.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            DirtTool_InHand.SetActive(false);
            DirtTool_TakenObj.SetActive(true);
            Trigger.SetActive(false);
            Text.SetActive(false);

            if (FuelTool_TakenObj == true)
            {
                FuelTool_TakenObj.SetActive(false);
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }
}

