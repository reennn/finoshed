using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilStick : MonoBehaviour
{
    private int countButton = 1;

    public GameObject steam_obj;
    public GameObject close_obj;
    void Awake()
    {
        steam_obj.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            countButton += 1;

            if (countButton % 2 == 0)
            {
                steam_obj.SetActive(true);
                close_obj.SetActive(false);
                Debug.Log("Люк открыт!");
            }
            else
            {
                steam_obj.SetActive(false);
                close_obj.SetActive(true);
                Debug.Log("Люк закрыт!");
            }
        }
    }
}
